using FluentValidation;
using MstBlog.Core.Entities;

namespace MstBlog.Service.Validations;

public class ContactValidator : AbstractValidator<Contact>
{
    public ContactValidator()
    {
        RuleFor(c => c.Email).EmailAddress().NotNull();
        RuleFor(c => c.Name).MinimumLength(4);
        RuleFor(c => c.Message).MinimumLength(10);
    }
}