using MAILSYSTEM.APPLICATION.Abstractions.Messaging;
using MAILSYSTEM.DOMAIN.Abstractions;
using MAILSYSTEM.DOMAIN.Entities;
using MAILSYSTEM.DOMAIN.Errors;
using MAILSYSTEM.DOMAIN.Repositories;

namespace MAILSYSTEM.APPLICATION.Accounts;

internal sealed class LoginCommandHandler : ICommandHandler<LoginCommand, string>
{
    private readonly IApiProvider _apiProvider;
    private readonly ICompanyRepository _companyRepository;

    public LoginCommandHandler(IApiProvider apiProvider, ICompanyRepository companyRepository)
    {
        _apiProvider = apiProvider;
        _companyRepository = companyRepository;
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

        if (company.CompanyPassword != request.password)
        {
            return Result.Failure<string>(
                DomainErrors.Company.InvalidCredentials);
        }

        string token = _apiProvider.GenerateApiKey(company);

        return token;
    }
}
