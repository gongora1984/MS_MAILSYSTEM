using MAILSYSTEM.DOMAIN.Contracts.Responses.Companies;

namespace MAILSYSTEM.APPLICATION.Persistence.Companies.Queries.CompanyById;

public sealed record GetCompanyByIdQuery(Guid companyId) : IQuery<CompanyResponse>;
