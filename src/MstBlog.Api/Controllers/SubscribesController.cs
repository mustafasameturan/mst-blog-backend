using Microsoft.AspNetCore.Mvc;
using MstBlog.Core.Models.Subscribe;
using MstBlog.Core.Services;

namespace MstBlog.Api.Controllers;

[Route("api/subscribes")]
[ApiController]
public class SubscribesController : BaseController
{
    private readonly ISubscribeService _subscribeService;

    public SubscribesController(ISubscribeService subscribeService)
    {
        _subscribeService = subscribeService;
    }

    [HttpPost("add")]
    public async Task<IActionResult> CreateRole([FromBody] AddSubsribeModel addSubsribeModel)
    {
        return CreateActionResult(await _subscribeService.AddAsync(addSubsribeModel));
    }
}