namespace MAILSYSTEM.APPLICATION.Persistence.Companies.Queries.CompanyByEmail;

internal class GetCompanyByEmailQueryValidator : AbstractValidator<GetCompanyByEmailQuery>
{
    public GetCompanyByEmailQueryValidator()
    {
        RuleFor(x => x.companyEmail).NotEmpty().WithMessage("Company Email is required").EmailAddress().WithMessage("A valid email address is required.");
    }
}
