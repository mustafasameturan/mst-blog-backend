using AutoMapper;
using Microsoft.AspNetCore.Identity;
using MstBlog.Core.Entities;
using MstBlog.Core.Models.Auth;
using MstBlog.Core.Models.Token;
using MstBlog.Core.Models.User;
using MstBlog.Core.Responses;
using MstBlog.Core.Services;
using MstBlog.Service.Constants;

namespace MstBlog.Service.Services;

public class AuthService : IAuthService
{
    private readonly ITokenService _tokenService;
    private readonly IMapper _mapper;
    private readonly UserManager<User> _userManager;

    public AuthService(IMapper mapper, UserManager<User> userManager, ITokenService tokenService)
    {
        _mapper = mapper;
        _userManager = userManager;
        _tokenService = tokenService;
    }

    /// <summary>
    /// This method used for login.
    /// </summary>
    /// <param name="loginModel"></param>
    /// <returns></returns>
    public async Task<Response<TokenModel>> LoginAsync(LoginModel loginModel)
    {
        if (loginModel == null)
            throw new ArgumentNullException(nameof(loginModel));

        var user = await _userManager.FindByEmailAsync(loginModel.Email);
        
        if (user == null) 
            return Response<TokenModel>.Fail(Messages.USER_NOT_FOUND, 404);

        if (!await _userManager.CheckPasswordAsync(user, loginModel.Password))
        {
            return Response<TokenModel>.Fail(Messages.PASSWORD_WRONG, 400);
        }

        var userRoles = await _userManager.GetRolesAsync(user);
        var token = _tokenService.CreateToken(user, userRoles);

        return Response<TokenModel>.Success(token, 200);
    }

    /// <summary>
    /// This method used for register users.
    /// </summary>
    /// <param name="registerModel"></param>
    /// <returns></returns>
    public async Task<Response<UserModel>> RegisterAsync(RegisterModel registerModel)
    {
        User user = new User
        {
            Email = registerModel.Email,
            FullName = registerModel.FullName,
            PhoneNumber = registerModel.PhoneNumber,
            UserName = registerModel.Email
        };

        var result = await _userManager.CreateAsync(user, registerModel.Password);

        if (!result.Succeeded)
        {
            var errors = result.Errors.Select(u => u.Description).ToList();
            
            return Response<UserModel>.Fail(new ErrorResponse(errors), 400);
        }
        
        await _userManager.AddToRoleAsync(user, Roles.User);
        return Response<UserModel>.Success(_mapper.Map<UserModel>(user), 200);
    }
}