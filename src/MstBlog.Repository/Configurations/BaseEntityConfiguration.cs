using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MstBlog.Core.Entities;

namespace MstBlog.Repository.Configurations;

public abstract class BaseEntityConfiguration<TEntity, TId> : IEntityTypeConfiguration<TEntity>
    where TEntity : BaseEntity<TId>
{
    public virtual void Configure(EntityTypeBuilder<TEntity> builder)
    {
        builder.HasKey(p => p.Id);

        builder.Property(p => p.CreatedDate)
            .IsRequired()
            .HasDefaultValue(DateTime.UtcNow);

        builder.Property(p => p.UpdatedDate)
            .HasDefaultValue(DateTime.UtcNow);

        builder.Property(p => p.Status);
    }
}