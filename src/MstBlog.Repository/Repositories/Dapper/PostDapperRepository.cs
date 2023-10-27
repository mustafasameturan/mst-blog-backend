using Dapper;
using MstBlog.Core.Entities;
using MstBlog.Core.Repositories;
using MstBlog.Repository.Contexts;

namespace MstBlog.Repository.Repositories;

public class PostDapperRepository : IPostDapperRepository
{
    private readonly MstBlogDapperContext _context;

    public PostDapperRepository(MstBlogDapperContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<Post>> GetAll()
    {
        var query = "SELECT * FROM Posts";
        
        using (var connection = _context.CreateConnection())
        {
            var companies = await connection.QueryAsync<Post>(query);
            return companies.ToList();
        }
    }
}