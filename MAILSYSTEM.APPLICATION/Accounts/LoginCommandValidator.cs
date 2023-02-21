using FluentValidation;

namespace MAILSYSTEM.APPLICATION.Accounts;

internal class LoginCommandValidator : AbstractValidator<LoginCommand>
{
    public LoginCommandValidator()
    {
        RuleFor(x => x.email).NotEmpty().WithMessage("Email address is required").EmailAddress().WithMessage("A valid email address is required.");

        RuleFor(x => x.password).NotEmpty().WithMessage("Password is required").MaximumLength(50).WithMessage("Maximum Length for password is 50 characters.");
    }
}
