using Microsoft.AspNetCore.Mvc;
using MstBlog.Core.Models.Project;
using MstBlog.Core.Services;

namespace MstBlog.Api.Controllers;

[Route("api/projects")]
[ApiController]
public class ProjectsController : BaseController
{
    private readonly IProjectService _projectService;

    public ProjectsController(IProjectService projectService)
    {
        _projectService = projectService;
    }
    
    [HttpGet("getAllProjects")]
    public async Task<IActionResult> GetAllProjects()
    {
        return CreateActionResult(await _projectService.GetAllAsync());
    }
    
    [HttpPost("addProject")]
    public async Task<IActionResult> AddProject(AddProjectModel addProjectModel)
    {
        return CreateActionResult(await _projectService.AddAsync(addProjectModel));
    }
}