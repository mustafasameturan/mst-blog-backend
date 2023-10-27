using ContentType = MstBlog.Core.Enums.ContentType;

namespace MstBlog.Core.Entities;

public class PostContent : BaseEntity<Guid>
{
    public Guid PostId { get; set; }
    public string Content { get; set; }
    public ContentType ContentType { get; set; }
    
    //Relations
    public Post Post { get; set; }
}