namespace MAILSYSTEM.APPLICATION.Persistence.Companies.Commands.CreateCompany;

internal class CreateCompanyCommandValidator : AbstractValidator<CreateCompanyCommand>
{
    public CreateCompanyCommandValidator()
    {
        RuleFor(x => x.company.companyName).NotEmpty().WithMessage("Company Name is required.");

        RuleFor(x => x.company.companyUsername).NotEmpty().WithMessage("Company Username is required.").EmailAddress().WithMessage("A valid email address is required.");

        RuleFor(x => x.company.companyPassword).NotEmpty().WithMessage("Password is required.").MaximumLength(50).WithMessage("Maximum length for password is 50 characters.");

        RuleFor(x => x.company.companyAddress1).NotEmpty().WithMessage("Company address 1 is required.").MaximumLength(250).WithMessage("Maximum length for address 1 is 250 characters.");

        RuleFor(x => x.company.companyCity).NotEmpty().WithMessage("Company city is required.").MaximumLength(50).WithMessage("Maximum length for city 1 is 250 characters.");

        RuleFor(x => x.company.companyState).NotEmpty().WithMessage("Company state is required.");

        RuleFor(x => x.company.companyZip).NotEmpty().WithMessage("Company zip is required.").MaximumLength(15).WithMessage("Maximum length for zip 1 is 15 characters.");

        RuleFor(x => x.company.companyBillingAddress1).NotEmpty().WithMessage("Company billing address 1 is required.").MaximumLength(250).WithMessage("Maximum length for billing address 1 is 250 characters.");

        RuleFor(x => x.company.companyBillingCity).NotEmpty().WithMessage("Company billing city is required.").MaximumLength(50).WithMessage("Maximum length for billing city 1 is 250 characters.");

        RuleFor(x => x.company.companyBillingState).NotEmpty().WithMessage("Company billing state is required.");

        RuleFor(x => x.company.companyBillingZip).NotEmpty().WithMessage("Company billing zip is required.").MaximumLength(15).WithMessage("Maximum length for billing zip 1 is 15 characters.");
    }
}
