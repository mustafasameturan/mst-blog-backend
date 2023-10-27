using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MstBlog.Core.Entities;

namespace MstBlog.Repository.Configurations;

public class ContactConfiguration : BaseEntityConfiguration<Contact, Guid>
{
    public void Configure(EntityTypeBuilder<Contact> builder)
    {
        builder.Property(p => p.Id).HasDefaultValueSql("NEWID()").ValueGeneratedOnAdd();
        builder.Property(p => p.Name).IsRequired();
        builder.Property(p => p.Email).IsRequired();
        builder.Property(p => p.Message).IsRequired();
    }
}