using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MstBlog.Core.Entities;

namespace MstBlog.Repository.Configurations;

public class PostContentConfiguration : BaseEntityConfiguration<PostContent, Guid>
{
    public void Configure(EntityTypeBuilder<PostContent> builder)
    {
        builder.Property(p => p.Id).HasDefaultValueSql("NEWID()").ValueGeneratedOnAdd();
        builder.Property(p => p.PostId).IsRequired();
        builder.Property(p => p.Content).IsRequired();
        builder.Property(p => p.ContentType).IsRequired();
        builder.HasOne(p => p.Post)
            .WithMany(p => p.PostContents)
            .HasForeignKey(p => p.PostId);
    }
}