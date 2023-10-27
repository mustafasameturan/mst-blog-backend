using Microsoft.AspNetCore.Mvc;
using MstBlog.Core.Models.Auth;
using MstBlog.Core.Services;

namespace MstBlog.Api.Controllers;

[Route("api/auths")]
[ApiController]
public class AuthsController : BaseController
{
    private readonly IAuthService _authService;

    public AuthsController(IAuthService authService)
    {
        _authService = authService;
    }
    
    [HttpPost("register")]
    public async Task<IActionResult> Register(RegisterModel registerModel)
    {
        return CreateActionResult(await _authService.RegisterAsync(registerModel));
    }

    [HttpPost("login")]
    public async Task<IActionResult> Login(LoginModel loginModel)
    {
        return CreateActionResult(await _authService.LoginAsync(loginModel));
    }
}