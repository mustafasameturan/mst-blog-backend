using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MstBlog.Core.Entities;

namespace MstBlog.Repository.Configurations;

public class PostCategoryConfiguration : BaseEntityConfiguration<PostCategory, Guid>
{
    public void Configure(EntityTypeBuilder<PostCategory> builder)
    {
        builder.Property(p => p.Id).HasDefaultValueSql("NEWID()").ValueGeneratedOnAdd();
        builder.Property(p => p.PostId).IsRequired();
        builder.Property(p => p.CategoryType).IsRequired();
        builder.HasOne(p => p.Post)
            .WithMany(p => p.PostCategories)
            .HasForeignKey(p => p.PostId);
    }
}