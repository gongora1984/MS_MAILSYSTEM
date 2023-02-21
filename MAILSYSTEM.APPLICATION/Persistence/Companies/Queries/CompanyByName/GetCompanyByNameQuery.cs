using MAILSYSTEM.DOMAIN.Contracts.Responses.Companies;

namespace MAILSYSTEM.APPLICATION.Persistence.Companies.Queries.CompanyByName;

public sealed record GetCompanyByNameQuery(string comanyName) : IQuery<CompanyResponse>;
