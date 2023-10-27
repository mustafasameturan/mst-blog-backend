namespace MstBlog.Core.Entities;

public class Project : BaseEntity<Guid>
{
    public string Name { get; set; }
    public string Description { get; set; }
    public string Url { get; set; }    
}