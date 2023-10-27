using Microsoft.AspNetCore.Mvc;
using MstBlog.Core.Models.Contact;
using MstBlog.Core.Services;

namespace MstBlog.Api.Controllers;

[Route("api/contacts")]
[ApiController]
public class ContactsController : BaseController
{
    private readonly IContactService _contactService;
    
    public ContactsController(IContactService contactService)
    {
        _contactService = contactService;
    }
    
    [HttpGet("getAllContacts")]
    public async Task<IActionResult> GetAllContacts()
    {
        return CreateActionResult(await _contactService.GetAllAsync());
    }
    
    [HttpPost("addContact")]
    public async Task<IActionResult> AddContact(AddContactModel addContactModel)
    {
        return CreateActionResult(await _contactService.AddAsync(addContactModel));
    }
}