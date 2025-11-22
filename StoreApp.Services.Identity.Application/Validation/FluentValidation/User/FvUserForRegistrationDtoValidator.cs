using FluentValidation;
using StoreApp.Services.Identity.Application.Constants.Messages;
using StoreApp.Services.Identity.Application.DTOs.User;

namespace StoreApp.Services.Identity.Application.Validation.FluentValidation.User;

public class FvUserForRegistrationDtoValidator : AbstractValidator<UserForRegistrationDto>
{
    public FvUserForRegistrationDtoValidator()
    {
        RuleFor(x => x.FirstName)
            .NotEmpty().WithMessage(MagicStrings.UserFirstNameNotEmpty);

        RuleFor(x => x.LastName)
            .NotEmpty().WithMessage(MagicStrings.UserLastNameNotEmpty);

        RuleFor(x => x.Username)
            .NotEmpty().WithMessage(MagicStrings.UserUsernameNotEmpty)
            .Length(3, 50).WithMessage(MagicStrings.UserUsernameLength);

        RuleFor(x => x.Email)
            .NotEmpty().WithMessage(MagicStrings.UserEmailNotEmpty)
            .EmailAddress().WithMessage(MagicStrings.UserEmailInvalid);

        RuleFor(x => x.Password)
            .NotEmpty().WithMessage(MagicStrings.UserPasswordNotEmpty)
            .MinimumLength(6).WithMessage(MagicStrings.UserPasswordLength)
            .Matches(@"[0-9]").WithMessage(MagicStrings.UserPasswordDigit)
            .Matches(@"[a-z]").WithMessage(MagicStrings.UserPasswordLowercase)
            .Matches(@"[A-Z]").WithMessage(MagicStrings.UserPasswordUppercase);
    }
}