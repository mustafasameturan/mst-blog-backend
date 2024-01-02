using MstBlog.Core.Enums;
using MstBlog.Core.Models.PostContent;
using MstBlog.Core.Models.User;

namespace MstBlog.Core.Models.Post;

public class GetPostByIdModel
{
    public string Title { get; set; }
    public GetUserInformationsModel UserInformations { get; set; }
    public List<string> PostCategories { get; set; }
    public List<GetPostContentModel> PostContents { get; set; }
}