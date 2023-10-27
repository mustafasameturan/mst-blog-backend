using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MstBlog.Core.Entities;

namespace MstBlog.Repository.Configurations;

public class ProjectConfiguration : BaseEntityConfiguration<Project, Guid>
{
    public void Configure(EntityTypeBuilder<Project> builder)
    {
        builder.Property(p => p.Id).HasDefaultValueSql("NEWID()").ValueGeneratedOnAdd();
        builder.Property(p => p.Name).IsRequired();
        builder.Property(p => p.Description).IsRequired();
        builder.Property(p => p.Url).IsRequired();
    }
}