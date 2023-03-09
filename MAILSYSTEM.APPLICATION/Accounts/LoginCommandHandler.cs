using MAILSYSTEM.DOMAIN.Abstractions;
using MAILSYSTEM.DOMAIN.Errors;

namespace MAILSYSTEM.APPLICATION.Accounts;

internal sealed class LoginCommandHandler : ICommandHandler<LoginCommand, string>
{
    private readonly ICompanyRepository _companyRepository;
    private readonly ISecurityProvider _securityProvider;

    public LoginCommandHandler(ICompanyRepository companyRepository, ISecurityProvider securityProvider)
    {
        _companyRepository = companyRepository;
        _securityProvider = securityProvider;
    }

    public async Task<Result<string>> Handle(LoginCommand request, CancellationToken cancellationToken)
    {
        Company? company = await _companyRepository.GetByEmailAsync(
            request.email,
            cancellationToken);

        if (company is null)
        {
            return Result.Failure<string>(
                DomainErrors.Company.InvalidUsername);
        }

        var matchPassword = _securityProvider.Verify(company.CompanyPassword, request.password);

        if (!matchPassword)
        {
            return Result.Failure<string>(
                DomainErrors.Company.InvalidCredentials);
        }

        var loginInformation = await _companyRepository.GetApiKeyByCompanyIdAsync(company.Id);

        if (loginInformation is null)
        {
            return Result.Failure<string>(
                DomainErrors.Company.NotFoundApiKey(company.Id));
        }

        return !string.IsNullOrEmpty(loginInformation.CompanyAccessToken)
            ? loginInformation.CompanyAccessToken
            : Result.Failure<string>(
                DomainErrors.Company.NotFoundApiKey(company.Id));
    }
}
