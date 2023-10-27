namespace MstBlog.Core.UnitOfWork;

public interface IUnitOfWork
{
    Task CommitAsync();
}