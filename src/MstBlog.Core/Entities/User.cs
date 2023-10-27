using Microsoft.AspNetCore.Identity;
using MstBlog.Core.Enums;

namespace MstBlog.Core.Entities;

public class User : IdentityUser
{
    public string FullName { get; set; }
    public DateTime? BirthDate { get; set; }
    public string EmailVerificationCode { get; set; }
    public string ResetPasswordVerificationCode { get; set; }
    public StatusType Status { get; set; }
    public ICollection<Post> Posts { get; set; }
}