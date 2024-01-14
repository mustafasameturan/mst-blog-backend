using System.ComponentModel.DataAnnotations;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using MstBlog.Core.Domain;
using MstBlog.Core.Entities;
using MstBlog.Core.Enums;
using MstBlog.Core.Models.Common;
using MstBlog.Core.Models.Filter;
using MstBlog.Core.Models.Post;
using MstBlog.Core.Repositories;
using MstBlog.Core.Responses;
using MstBlog.Core.Services;
using MstBlog.Core.UnitOfWork;
using MstBlog.Service.Constants;

namespace MstBlog.Service.Services;

public class PostService : IPostService
{
    private readonly IGenericRepository<Post> _postRepository;
    private readonly IMapper _mapper;
    private readonly IUnitOfWork _unitOfWork;

    public PostService(IGenericRepository<Post> postRepository, IMapper mapper, IUnitOfWork unitOfWork)
    {
        _postRepository = postRepository;
        _mapper = mapper;
        _unitOfWork = unitOfWork;
    }

    /// <summary>
    /// This method gets all posts
    /// </summary>
    /// <returns></returns>
    public async Task<Response<ListPostFilterModel>> GetAllAsync(FilterRequestModel requestModel)
    {
        List<Post> posts = await _postRepository
            .GetAll()
            .Include(p => p.User)
            .Include(p => p.PostCategories)
            .Where(p => p.Status == StatusType.Active)
            .Skip(requestModel.Start)
            .Take(requestModel.Limit)
            .ToListAsync();

        int totalRecordsCount = await _postRepository.CountAsync();
        
        int filteredRecordsCount = posts.Count();

        var responseModel = new ListPostFilterModel(
            _mapper.Map<List<ListPostModel>>(posts),
            totalRecordsCount,
            filteredRecordsCount
        );

        return Response<ListPostFilterModel>.Success(responseModel, 200);
    }

    /// <summary>
    /// This method gets top (*) posts
    /// </summary>
    /// <param name="count"></param>
    /// <returns></returns>
    public async Task<Response<IEnumerable<ListPostModel>>> GetTopPostsAsync(int count)
    {
        List<Post> topPosts = await _postRepository
            .Queryable()
            .Include(p => p.User)
            .Include(p => p.PostCategories)
            .Where(p => p.Status == StatusType.Active)
            .OrderByDescending(t => t.CreatedDate)
            .Take(count)
            .ToListAsync();
        
        return Response<IEnumerable<ListPostModel>>.Success(_mapper.Map<IEnumerable<ListPostModel>>(topPosts), 200);
    }

    /// <summary>
    /// This method gets all posts with dapper 
    /// </summary>
    /// <returns></returns>
    public async Task<Response<IEnumerable<ListPostModel>>> GetAllWithDapperAsync()
    {
        List<Post> posts = await _postRepository.GetAll().ToListAsync();

        return Response<IEnumerable<ListPostModel>>.Success(_mapper.Map<IEnumerable<ListPostModel>>(posts), 200);
    }

    /// <summary>
    /// This method add new post
    /// </summary>
    /// <param name="addPostModel"></param>
    /// <returns></returns>
    public async Task<Response<AddPostModel>> AddAsync(AddPostModel addPostModel)
    {
        Post newPost = new Post
        {
            Title = addPostModel.Title,
            UserId = addPostModel.UserId,
            Link = RandomStringHelper.GenerateRandomString(8),
            PostCategories = addPostModel.PostCategories
                .Select(pca => new PostCategory
                {
                    CategoryType = pca
                }).ToList(),
            PostContents = addPostModel.PostContents
                .Select(pco => new PostContent
                {
                    Content = pco.Content,
                    ContentType = pco.ContentType
                }).ToList()
        };
        
        await _postRepository.AddAsync(newPost);
        await _unitOfWork.CommitAsync();
        
        return Response<AddPostModel>.Success(200);
    }

    /// <summary>
    /// This method get posts by id.
    /// </summary>
    /// <param name="postId"></param>
    /// <returns></returns>
    /// <exception cref="Exception"></exception>
    public async Task<Response<GetPostByLinkModel>> GetPostByLink(string link)
    {
        var postDetail = await _postRepository
            .Queryable()
            .Include(p => p.User)
            .Include(p => p.PostCategories)
            .Include(p => p.PostContents)
            .Where(p => p.Link.Equals(link))
            .FirstOrDefaultAsync();

        if (postDetail is null)
            throw new Exception(Messages.POST_NOT_FOUND);

        return Response<GetPostByLinkModel>.Success(_mapper.Map<GetPostByLinkModel>(postDetail), 200);
    }

    /// <summary>
    /// This method update related post read time.
    /// </summary>
    /// <param name="updateReadTimeModel"></param>
    /// <returns></returns>
    public async Task<Response<int>> UpdateReadTimeByPostLinkAsync(UpdateReadTimeModel updateReadTimeModel)
    {
        var post = await _postRepository
            .Queryable()
            .FirstOrDefaultAsync(p => p.Link.Equals(updateReadTimeModel.PostLink));
        
        ArgumentNullException.ThrowIfNull(post);

        post.ReadTime += updateReadTimeModel.ReadTime;
        await _unitOfWork.CommitAsync();
        
        return Response<int>.Success(post.ReadTime, 200);
    }

    /// <summary>
    /// This method list post content types
    /// </summary>
    /// <returns></returns>
    public Response<IEnumerable<SelectListModel>> GetPostContentTypes()
    {
        var contentTypes = Enum.GetValues(typeof(ContentType))
            .Cast<ContentType>()
            .Select(ct => new SelectListModel
            {
                Id = (int)ct,
                Title = EnumHelper.GetDisplayName(ct)
            })
            .ToList();

        return Response<IEnumerable<SelectListModel>>.Success(contentTypes, 200);
    }

    /// <summary>
    /// This method list post category types
    /// </summary>
    /// <returns></returns>
    public Response<IEnumerable<SelectListModel>> GetPostCategoryTypes()
    {
        var categoryTypes = Enum.GetValues(typeof(CategoryType))
            .Cast<CategoryType>()
            .Select(ct => new SelectListModel
            {
                Id = (int)ct,
                Title = EnumHelper.GetDisplayName(ct)
            })
            .ToList();

        return Response<IEnumerable<SelectListModel>>.Success(categoryTypes, 200);
    }
}