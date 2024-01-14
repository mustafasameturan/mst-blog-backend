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

    [HttpGet("getPostByLink/{link}")]
    public async Task<IActionResult> GetPostByLink([FromRoute] string link)
    {
        return CreateActionResult(await _postService.GetPostByLink(link));
    }
    
    [HttpGet("getAllPostsWithDapper")]
    public async Task<IActionResult> GetAllProjectsWithDapper()
    {
        return CreateActionResult(await _postService.GetAllWithDapperAsync());
    }
    
    [HttpPost("addPost")]
    public async Task<IActionResult> AddProject([FromBody]AddPostModel addProjectModel)
    {
        return CreateActionResult(await _postService.AddAsync(addProjectModel));
    }
    
    [HttpPut("updateReadTime")]
    public async Task<IActionResult> UpdateReadTime([FromBody]UpdateReadTimeModel updateReadTimeModel)
    {
        return CreateActionResult(await _postService.UpdateReadTimeByPostLinkAsync(updateReadTimeModel));
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