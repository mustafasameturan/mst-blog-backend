using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MstBlog.Core.Entities;

namespace MstBlog.Repository.Configurations;

public class UserConfiguration : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.Property(p => p.FullName).HasMaxLength(150);
        builder.Property(p => p.BirthDate).IsRequired(false);
        builder.Property(p => p.ResetPasswordVerificationCode).IsRequired(false);
        builder.Property(p => p.EmailVerificationCode).IsRequired(false);
        builder.Property(p => p.Status).IsRequired();
    }
}