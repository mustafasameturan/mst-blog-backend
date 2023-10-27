namespace MstBlog.Core.Responses;

public class ErrorResponse
{
    // the private uses reason is to prevent the user from changing the list
    public List<string> Errors { get; private set; } = new List<string>();

    public ErrorResponse(string error)
    {
        Errors = new List<string>();
        Errors.Add(error);
    }

    public ErrorResponse(List<string> errors)
    {
        Errors = errors;
    }
}