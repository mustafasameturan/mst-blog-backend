using MstBlog.Core.Enums;

namespace MstBlog.Core.Entities;

public abstract class BaseEntity<TId> : BaseEntity
{
    public TId Id { get; set; }
}

public abstract class BaseEntity
{
    public StatusType Status { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime UpdatedDate { get; set; }
}