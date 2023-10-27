using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using MstBlog.Core.Domain;
using MstBlog.Core.Entities;
using MstBlog.Core.Models.Token;
using MstBlog.Core.Services;

namespace MstBlog.Service.Services;

public class TokenService : ITokenService
{
    private readonly TokenSettings _tokenSettings;

    public TokenService(IOptions<TokenSettings> options)
    {
        _tokenSettings = options.Value;
    }
    
    /// <summary>
    /// This method used for create token.
    /// </summary>
    /// <param name="userApp"></param>
    /// <returns></returns>
    public TokenModel CreateToken(User user, IList<string> userRoles)
    {
        var accessTokenExpiration = DateTime.Now.AddMinutes(_tokenSettings.Expiration);
        var securityKey = SignService.GetSymmetricSecurityKey(_tokenSettings.SecurityKey);
        
        SigningCredentials signingCredentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256Signature);

        JwtSecurityToken jwtSecurityToken = new JwtSecurityToken(
            issuer: _tokenSettings.Issuer,
            expires: accessTokenExpiration,
            notBefore: DateTime.Now,
            claims: GetClaims(user, userRoles),
            signingCredentials: signingCredentials);

        var handler = new JwtSecurityTokenHandler();

        var token = handler.WriteToken(jwtSecurityToken);

        var tokenModel = new TokenModel
        {
            Token = token,
            TokenExpiration = accessTokenExpiration,
        };

        return tokenModel;
    }

    private List<Claim> GetClaims(User user, IList<string> userRoles)
    {
        var claims = new List<Claim>
        {
            new Claim("UserId", user.Id),
            new Claim("UserEmail", user.Email),
            new Claim("UserName", user.UserName),
            new Claim("UserFullName", user.FullName),
            new Claim("IsUserVerificated", user.EmailConfirmed.ToString()),
            new Claim("UserRoles", string.Join(",", userRoles))
        };

        return claims;
    }
}