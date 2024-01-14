using MstBlog.Core.Models.PostContent;
using MstBlog.Core.Models.User;

namespace MstBlog.Core.Models.Post;

public class GetPostByLinkModel
{
    public string Title { get; set; }
    public string Link { get; set; }
    public double ReadTime { get; set; }
    public DateTime CreatedDate { get; set; }
    public GetUserInformationsModel UserInformations { get; set; }
    public List<string> PostCategories { get; set; }
    public List<GetPostContentModel> PostContents { get; set; }
}