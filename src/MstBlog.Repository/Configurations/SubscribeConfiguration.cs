using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MstBlog.Core.Entities;

namespace MstBlog.Repository.Configurations;

public class SubscribeConfiguration : BaseEntityConfiguration<Subscribe, Guid>
{
    public void Configure(EntityTypeBuilder<Subscribe> builder)
    {
        builder.Property(p => p.Id).HasDefaultValueSql("NEWID()").ValueGeneratedOnAdd();
        builder.Property(p => p.Email).IsRequired();
    }
}