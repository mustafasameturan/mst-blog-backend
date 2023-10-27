namespace MstBlog.Core.Models.User;

public class UserModel
{
    public string Id { get; set; }
    public string FullName { get; set; }
    public string Email { get; set; }
    public string City { get; set; }
    public string PhoneNumber { get; set; }
    public DateTime? BirthDate { get; set; }
}