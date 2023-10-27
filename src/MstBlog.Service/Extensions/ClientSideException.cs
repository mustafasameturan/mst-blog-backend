namespace MstBlog.Service.Extensions;

public class ClientSideException : Exception
{
    public ClientSideException(string message) : base(message)
    {
        
    }
}