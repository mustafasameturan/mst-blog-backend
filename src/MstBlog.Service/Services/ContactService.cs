using System.Collections;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using MstBlog.Core.Domain;
using MstBlog.Core.Entities;
using MstBlog.Core.Models.Contact;
using MstBlog.Core.Repositories;
using MstBlog.Core.Responses;
using MstBlog.Core.Services;
using MstBlog.Core.UnitOfWork;

namespace MstBlog.Service.Services;

public class ContactService : IContactService
{
    private readonly IGenericRepository<Contact> _contactRepository;
    private readonly IMapper _mapper;
    private readonly IUnitOfWork _unitOfWork;
    private readonly IEmailService _emailService;
    private string _senderEmail;

    public ContactService(
            IGenericRepository<Contact> contactRepository, 
            IMapper mapper, 
            IUnitOfWork unitOfWork, 
            IEmailService emailService,
            IConfiguration configuration
        )
    {
        _contactRepository = contactRepository;
        _mapper = mapper;
        _unitOfWork = unitOfWork;
        _emailService = emailService;
        _senderEmail = configuration[SettingNames.SenderEmail];
    }

    /// <summary>
    /// Get all contacts 
    /// </summary>
    /// <returns></returns>
    public async Task<Response<IEnumerable<ListContactModel>>> GetAllAsync()
    {
        List<Contact> contacts = await _contactRepository.GetAll().ToListAsync();
        
        return Response<IEnumerable<ListContactModel>>.Success(_mapper.Map<IEnumerable<ListContactModel>>(contacts), 200);
    }

    /// <summary>
    /// This method add new contact
    /// </summary>
    /// <param name="addContactModel"></param>
    /// <returns></returns>
    public async Task<Response<AddContactModel>> AddAsync(AddContactModel addContactModel)
    {
        Contact newContact = _mapper.Map<Contact>(addContactModel);

        await _contactRepository.AddAsync(newContact);

        await _unitOfWork.CommitAsync();

        AddContactModel newModel = _mapper.Map<AddContactModel>(newContact);

        string mailSubject = addContactModel.Name + " " + addContactModel.Email;
        
        _emailService.SendEmail(_senderEmail, _senderEmail, mailSubject, addContactModel.Message);
        return Response<AddContactModel>.Success(200);
    }
}