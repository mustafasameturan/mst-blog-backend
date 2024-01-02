using Microsoft.Extensions.Primitives;
using MstBlog.Core.Domain;

namespace MstBlog.Api.Middlewares;

public class ApiKeyAuthorizationMiddleware
{
    private readonly RequestDelegate _next;
    private readonly IConfiguration _configuration;

    public ApiKeyAuthorizationMiddleware(RequestDelegate next, IConfiguration configuration)
    {
        _next = next;
        _configuration = configuration;
    }

    public async Task InvokeAsync(HttpContext httpContext)
    {
        var requestPath = httpContext.Request.Path.Value ?? "/";

        if (!httpContext.Request.Headers.Contains(new KeyValuePair<string, StringValues>("api-key", _configuration[SettingNames.ApiKey]))
            && !requestPath.Contains("swagger"))
        {
            httpContext.Response.StatusCode = StatusCodes.Status401Unauthorized;
            await httpContext.Response.WriteAsync("What are you doing piece of shit??????");
            return;
        }

        await _next(httpContext);
    }
}