using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using MstBlog.Core.Models.Common;
using MstBlog.Core.Responses;
using MstBlog.Core.Services;

namespace MstBlog.Service.Services;

public class RoleService : IRoleService
{
    private readonly RoleManager<IdentityRole> _roleManager;

    public RoleService(RoleManager<IdentityRole> roleManager)
    {
        _roleManager = roleManager;
    }

    /// <summary>
    /// This method used for create role for users.
    /// </summary>
    /// <param name="roleName"></param>
    /// <returns></returns>
    public async Task<Response<NoDataModel>> CreateRoleAsync(string roleName)
    {
        var roleExist = await _roleManager.RoleExistsAsync(roleName);

        if (!roleExist)
        {
            var newRole = new IdentityRole(roleName);
            var result = await _roleManager.CreateAsync(newRole);

            if (result.Succeeded)
            {
                return Response<NoDataModel>.Success("Role was created!", 204);
            }
        }
        
        return Response<NoDataModel>.Success("There is an error when role creating!", 400);
    }
    
    /// <summary>
    /// This method get role by name.
    /// </summary>
    /// <param name="roleName"></param>
    /// <returns></returns>
    public async Task<Response<IdentityRole>> GetRoleByName(string roleName)
    {
        var role = await _roleManager.FindByNameAsync(roleName);

        if (role is null)
        {
            return Response<IdentityRole>.Fail("Role is not found!", 404);
        }

        return Response<IdentityRole>.Success(role, 200);
    }
    
    /// <summary>
    /// This method get all roles
    /// </summary>
    /// <returns></returns>
    public async Task<List<string>> GetAllAsync()
    {
        var roles = await _roleManager.Roles.Select(r => r.Name).ToListAsync();

        return roles;
    }
}