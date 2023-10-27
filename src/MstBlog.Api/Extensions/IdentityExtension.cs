using Microsoft.AspNetCore.Identity;
using MstBlog.Core.Entities;
using MstBlog.Repository.Contexts;
using MstBlog.Service.Constants;

namespace MstBlog.Api.Extensions;

public static class IdentityExtension
{
    public static void AddIdentity(this IServiceCollection services)
    {
        //Identity Configurations
        services.AddIdentity<User, IdentityRole>(Opt =>
            {
                Opt.User.RequireUniqueEmail = true;

                Opt.Password.RequiredLength = 6;
                Opt.Password.RequireLowercase = true;
                Opt.Password.RequireUppercase = false;
                Opt.Password.RequireNonAlphanumeric = false;
                Opt.Password.RequireDigit = false;

            })
            .AddErrorDescriber<ErrorDescriber>()
            .AddEntityFrameworkStores<MstBlogDbContext>()
            .AddDefaultTokenProviders();
    }
}