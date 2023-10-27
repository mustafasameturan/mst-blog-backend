using System.Collections;
using MstBlog.Core.Models.Post;
using MstBlog.Core.Responses;

namespace MstBlog.Core.Services;

public interface IPostService
{
    Task<Response<IEnumerable<ListPostModel>>> GetAllAsync();
    
    Task<Response<IEnumerable<ListPostModel>>> GetAllWithDapperAsync();
    
    Task<Response<AddPostModel>> AddAsync(AddPostModel addPostModel);
}