using MstBlog.Core.Entities;

namespace MstBlog.Core.Repositories;

public interface IPostDapperRepository
{
    Task<IEnumerable<Post>> GetAll();
}