using MstBlog.Core.Models.Project;
using MstBlog.Core.Responses;

namespace MstBlog.Core.Services;

public interface IProjectService
{
    Task<Response<IEnumerable<ListProjectsModel>>> GetAllAsync();   
    Task<Response<AddProjectModel>> AddAsync(AddProjectModel projectAddModel);
}