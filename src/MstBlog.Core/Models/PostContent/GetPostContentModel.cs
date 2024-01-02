using MstBlog.Core.Enums;

namespace MstBlog.Core.Models.PostContent;

public class GetPostContentModel
{
    public string Content { get; set; }
    public ContentType ContentType { get; set; }
}