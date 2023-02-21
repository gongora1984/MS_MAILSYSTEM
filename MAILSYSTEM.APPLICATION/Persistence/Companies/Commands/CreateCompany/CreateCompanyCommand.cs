using MAILSYSTEM.DOMAIN.Contracts.Requests;

namespace MAILSYSTEM.APPLICATION.Persistence.Companies.Commands.CreateCompany;

public record CreateCompanyCommand(RegisterCompanyRequest company) : ICommand<string>;
