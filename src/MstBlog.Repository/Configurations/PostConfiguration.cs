using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MstBlog.Core.Entities;

namespace MstBlog.Repository.Configurations;

public class PostConfiguration : BaseEntityConfiguration<Post, Guid>
{
    public void Configure(EntityTypeBuilder<Post> builder)
    {
        builder.HasKey(p => p.Id);
        builder.Property(p => p.Id).HasDefaultValueSql("NEWID()").ValueGeneratedOnAdd();
        builder.Property(p => p.Link).IsRequired();
        builder.Property(p => p.Title).IsRequired();
        builder.Property(p => p.ReadTime).HasDefaultValue(0);

        builder
            .HasOne(p => p.User)
            .WithMany(p => p.Posts)
            .HasForeignKey(p => p.UserId);

    }
}