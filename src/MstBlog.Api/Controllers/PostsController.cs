using Microsoft.AspNetCore.Mvc;
using MstBlog.Core.Models.Filter;
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
    
    [HttpPost("getAllPosts")]
    public async Task<IActionResult> GetAllPosts([FromBody]FilterRequestModel requestModel)
    {
        return CreateActionResult(await _postService.GetAllAsync(requestModel));
    }
    
    [HttpGet("getTopPosts/{count:int}")]
    public async Task<IActionResult> GetTopPosts([FromRoute] int count)
    {
        return CreateActionResult(await _postService.GetTopPostsAsync(count));
    }

    [HttpGet("getPostById/{postId:guid}")]
    public async Task<IActionResult> GetPostById([FromRoute] Guid postId)
    {
        return CreateActionResult(await _postService.GetPostByIdAsync(postId));
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
    
    [HttpGet("getPostCategoryTypes")]
    public IActionResult GetPostCategoryTypes()
    {
        return CreateActionResult(_postService.GetPostCategoryTypes());
    }
    
    [HttpGet("getPostContentTypes")]
    public IActionResult GetPostContentTypes()
    {
        return CreateActionResult(_postService.GetPostContentTypes());
    }
}