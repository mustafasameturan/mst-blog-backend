using MstBlog.Core.Enums;
using MstBlog.Core.Models.PostContent;

namespace MstBlog.Core.Models.Post;

public class AddPostModel
{
    public string Title { get; set; }
    public string UserId { get; set; }
    public List<CategoryType> PostCategories { get; set; }
    public List<AddPostContentModel> PostContents { get; set; }
}