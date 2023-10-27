using MstBlog.Core.UnitOfWork;
using MstBlog.Repository.Contexts;

namespace MstBlog.Repository.UnitOfWork;

public class UnitOfWork : IUnitOfWork
{
    private readonly MstBlogDbContext _context;

    public UnitOfWork(MstBlogDbContext context)
    {
        _context = context;
    }

    public async Task CommitAsync()
    {
        await _context.SaveChangesAsync();
    }
}