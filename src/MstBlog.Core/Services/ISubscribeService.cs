using MstBlog.Core.Models.Subscribe;
using MstBlog.Core.Responses;

namespace MstBlog.Core.Services;

public interface ISubscribeService
{
    Task<Response<IEnumerable<ListSubscribeModel>>> GetAllAsync();
    
    Task<Response<AddSubsribeModel>> AddAsync(AddSubsribeModel addSubsribeModel);
}