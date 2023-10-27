using MstBlog.Core.Entities;
using MstBlog.Core.Models.Token;

namespace MstBlog.Core.Services;

public interface ITokenService
{
    TokenModel CreateToken(User user, IList<string> userRoles);
}