namespace MstBlog.Core.Entities;

public class Subscribe : BaseEntity<Guid>
{
    public string Email { get; set; }
}