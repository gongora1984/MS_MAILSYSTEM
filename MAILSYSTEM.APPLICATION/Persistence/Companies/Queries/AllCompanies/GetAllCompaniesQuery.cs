using MAILSYSTEM.DOMAIN.Contracts.Responses.Companies;

namespace MAILSYSTEM.APPLICATION.Persistence.Companies.Queries.AllCompanies;

public record GetAllCompaniesQuery : IRequest<AllCompaniesResponse>;
