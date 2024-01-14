using System.Collections;
using MstBlog.Core.Models.Common;
using MstBlog.Core.Models.Filter;
using MstBlog.Core.Models.Post;
using MstBlog.Core.Responses;

namespace MstBlog.Core.Services;

public interface IPostService
{
    Task<Response<ListPostFilterModel>> GetAllAsync(FilterRequestModel requestModel);
    
    Task<Response<IEnumerable<ListPostModel>>> GetTopPostsAsync(int count);
    
    Task<Response<IEnumerable<ListPostModel>>> GetAllWithDapperAsync();
    
    Task<Response<AddPostModel>> AddAsync(AddPostModel addPostModel);

    Task<Response<GetPostByLinkModel>> GetPostByLink(string link);

    Task<Response<int>> UpdateReadTimeByPostLinkAsync(UpdateReadTimeModel updateReadTimeModel);  

    Response<IEnumerable<SelectListModel>> GetPostContentTypes();

    Response<IEnumerable<SelectListModel>> GetPostCategoryTypes();
}