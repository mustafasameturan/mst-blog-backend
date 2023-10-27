using System.Security.AccessControl;
using MstBlog.Core.Enums;

namespace MstBlog.Core.Entities;

public class PostCategory : BaseEntity<Guid>
{
    public Guid PostId { get; set; }
    public CategoryType CategoryType { get; set; }
    public Post Post { get; set; }
}