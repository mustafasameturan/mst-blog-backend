namespace MstBlog.Api.Extensions;

public static class CorsExtension
{
    public static void UseCors(this IServiceCollection services)
    {
        services.AddCors(options =>
        {
            options.AddPolicy("MyAllowedOrigins",
                policy =>
                {
                    policy.WithOrigins("http://localhost:3001") 
                        .AllowAnyHeader()
                        .AllowAnyMethod();
                    
                    policy.WithOrigins("https://mst-blog.vercel.app") 
                        .AllowAnyHeader()
                        .AllowAnyMethod();
                });
        });
    }
}