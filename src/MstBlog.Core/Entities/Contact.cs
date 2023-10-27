namespace MstBlog.Core.Entities;

public class Contact : BaseEntity<Guid>
{
    public string Name { get; set; }
    public string Email { get; set; }
    public string Message { get; set; }
}