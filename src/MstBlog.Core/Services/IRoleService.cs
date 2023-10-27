using Microsoft.AspNetCore.Identity;
using MstBlog.Core.Models.Common;
using MstBlog.Core.Responses;

namespace MstBlog.Core.Services;

public interface IRoleService
{
    Task<List<string>> GetAllAsync();
    Task<Response<IdentityRole>> GetRoleByName(string roleName);
    Task<Response<NoDataModel>> CreateRoleAsync(string roleName);
}