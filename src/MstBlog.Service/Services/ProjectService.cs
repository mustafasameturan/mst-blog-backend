using AutoMapper;
using Microsoft.EntityFrameworkCore;
using MstBlog.Core.Entities;
using MstBlog.Core.Models.Project;
using MstBlog.Core.Repositories;
using MstBlog.Core.Responses;
using MstBlog.Core.Services;
using MstBlog.Core.UnitOfWork;

namespace MstBlog.Service.Services;

public class ProjectService : IProjectService
{
    private readonly IGenericRepository<Project> _projectRepository;
    private readonly IMapper _mapper;
    private readonly IUnitOfWork _unitOfWork;

    public ProjectService(IUnitOfWork unitOfWork ,IGenericRepository<Project> projectRepository, IMapper mapper)
    {
        _projectRepository = projectRepository;
        _mapper = mapper;
        _unitOfWork = unitOfWork;
    }

    /// <summary>
    /// Gets the project
    /// </summary>
    /// <returns></returns>
    public async Task<Response<IEnumerable<ListProjectsModel>>> GetAllAsync()
    {
        var entities = await _projectRepository.GetAll().ToListAsync();

        return Response<IEnumerable<ListProjectsModel>>.Success(_mapper.Map<IEnumerable<ListProjectsModel>>(entities), 200);
    }

    /// <summary>
    /// This method add new project
    /// </summary>
    /// <param name="addProjectModel"></param>
    /// <returns></returns>
    public async Task<Response<AddProjectModel>> AddAsync(AddProjectModel addProjectModel)
    {
        var newEntity = _mapper.Map<Project>(addProjectModel);

        await _projectRepository.AddAsync(newEntity);

        await _unitOfWork.CommitAsync();

        var newModel = _mapper.Map<AddProjectModel>(newEntity);

        return Response<AddProjectModel>.Success(newModel, 204);
    }
}