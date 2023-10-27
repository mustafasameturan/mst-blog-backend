using MstBlog.Core.Models.Auth;
using MstBlog.Core.Models.Token;
using MstBlog.Core.Models.User;
using MstBlog.Core.Responses;

namespace MstBlog.Core.Services;

public interface IAuthService
{
    Task<Response<TokenModel>> LoginAsync(LoginModel loginModel);
    Task<Response<UserModel>> RegisterAsync(RegisterModel registerModel);
}