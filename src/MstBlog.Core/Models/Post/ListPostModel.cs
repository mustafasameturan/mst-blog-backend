namespace MstBlog.Core.Models.Post;

public class ListPostModel
{
    public Guid Id { get; set; }
    public string Title { get; set; }
    public double ReadTime { get; set; }
    public string FullName { get; set; }
    public IEnumerable<string> PostCategories { get; set; }
    public DateTime CreatedDate { get; set; }
}