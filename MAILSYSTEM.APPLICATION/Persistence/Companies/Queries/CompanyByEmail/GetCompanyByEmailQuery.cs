using MAILSYSTEM.DOMAIN.Contracts.Responses.Companies;

namespace MAILSYSTEM.APPLICATION.Persistence.Companies.Queries.CompanyByEmail;

public sealed record GetCompanyByEmailQuery(string companyEmail) : IQuery<CompanyResponse>;
