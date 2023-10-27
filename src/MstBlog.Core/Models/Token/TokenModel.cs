namespace MstBlog.Core.Models.Token;

public class TokenModel
{
    public string Token { get; set; }
    public DateTime TokenExpiration { get; set; }
}