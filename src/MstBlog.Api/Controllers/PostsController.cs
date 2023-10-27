using Microsoft.AspNetCore.Mvc;
using MstBlog.Core.Models.Post;
using MstBlog.Core.Services;

namespace MstBlog.Api.Controllers;

[Route("api/posts")]
[ApiController]
public class PostsController : BaseController
{
    private readonly IPostService _postService;

    public PostsController(IPostService postService)
    {
        _postService = postService;
    }
    
    [HttpGet("getAllPosts")]
    public async Task<IActionResult> GetAllProjects()
    {
        return CreateActionResult(await _postService.GetAllAsync());
    }
    
    [HttpGet("getAllPostsWithDapper")]
    public async Task<IActionResult> GetAllProjectsWithDapper()
    {
        return CreateActionResult(await _postService.GetAllWithDapperAsync());
    }
    
    [HttpPost("addPost")]
    public async Task<IActionResult> AddProject(AddPostModel addProjectModel)
    {
        return CreateActionResult(await _postService.AddAsync(addProjectModel));
    }
}