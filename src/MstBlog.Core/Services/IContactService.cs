using MstBlog.Core.Models.Contact;
using MstBlog.Core.Responses;

namespace MstBlog.Core.Services;

public interface IContactService
{
    Task<Response<IEnumerable<ListContactModel>>> GetAllAsync();
    Task<Response<AddContactModel>> AddAsync(AddContactModel addContactModel);
}