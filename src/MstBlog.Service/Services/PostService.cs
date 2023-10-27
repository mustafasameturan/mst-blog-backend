using AutoMapper;
using Microsoft.EntityFrameworkCore;
using MstBlog.Core.Entities;
using MstBlog.Core.Models.Post;
using MstBlog.Core.Models.Project;
using MstBlog.Core.Repositories;
using MstBlog.Core.Responses;
using MstBlog.Core.Services;
using MstBlog.Core.UnitOfWork;

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
    public async Task<Response<IEnumerable<ListPostModel>>> GetAllAsync()
    {
        List<Post> posts = await _postRepository.GetAll().ToListAsync();

        return Response<IEnumerable<ListPostModel>>.Success(_mapper.Map<IEnumerable<ListPostModel>>(posts), 200);
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
        
        return Response<AddPostModel>.Success(204);
    }
}