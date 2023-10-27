namespace MstBlog.Core.Entities;

public class Post : BaseEntity<Guid>
{
    public string Title { get; set; }
    public string UserId { get; set; }
    public double ReadTime { get; set; }
    
    public User User { get; set; }
    public ICollection<PostCategory> PostCategories { get; set; }
    public ICollection<PostContent> PostContents { get; set; }
}