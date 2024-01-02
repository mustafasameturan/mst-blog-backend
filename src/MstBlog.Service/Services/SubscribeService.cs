using AutoMapper;
using Microsoft.EntityFrameworkCore;
using MstBlog.Core.Entities;
using MstBlog.Core.Models.Common;
using MstBlog.Core.Models.Subscribe;
using MstBlog.Core.Repositories;
using MstBlog.Core.Responses;
using MstBlog.Core.Services;
using MstBlog.Core.UnitOfWork;
using MstBlog.Service.Constants;

namespace MstBlog.Service.Services;

public class SubscribeService : ISubscribeService
{
    private readonly IGenericRepository<Subscribe> _subscribeRepository;
    private readonly IMapper _mapper;
    private readonly IUnitOfWork _unitOfWork;

    public SubscribeService(IGenericRepository<Subscribe> subscribeRepository, IMapper mapper, IUnitOfWork unitOfWork)
    {
        _subscribeRepository = subscribeRepository;
        _mapper = mapper;
        _unitOfWork = unitOfWork;
    }

    /// <summary>
    /// Get all subscribes
    /// </summary>
    /// <returns></returns>
    public async Task<Response<IEnumerable<ListSubscribeModel>>> GetAllAsync()
    {
        List<Subscribe> subscribes = await _subscribeRepository.GetAll().ToListAsync();
        
        return Response<IEnumerable<ListSubscribeModel>>.Success(_mapper.Map<IEnumerable<ListSubscribeModel>>(subscribes), 200);
    }

    /// <summary>
    /// Add new subscribe
    /// </summary>
    /// <param name="addSubsribeModel"></param>
    /// <returns></returns>
    public async Task<Response<NoDataModel>> AddAsync(AddSubsribeModel addSubsribeModel)
    {

        bool isExistSubscribe = await _subscribeRepository
            .AnyAsync(s => s.Email == addSubsribeModel.Email);

        if (isExistSubscribe)
        {
            return Response<NoDataModel>.Fail(Messages.SUBSCRIBE_EXIST, 400);
        }
        
        Subscribe newSubscribe = _mapper.Map<Subscribe>(addSubsribeModel);
        
        await _subscribeRepository.AddAsync(newSubscribe);

        await _unitOfWork.CommitAsync();

        AddSubsribeModel newModel = _mapper.Map<AddSubsribeModel>(newSubscribe);

        return Response<NoDataModel>.Success(200);
    }
}