using MAILSYSTEM.DOMAIN.Contracts.Responses.Companies;

namespace MAILSYSTEM.APPLICATION.Persistence.Companies.Queries.AllCompanies;

public sealed class GetAllCompaniesQueryHandler : IRequestHandler<GetAllCompaniesQuery, AllCompaniesResponse>
{
    private readonly ICompanyRepository _companyRepository;
    private readonly IMapper _mapper;

    public GetAllCompaniesQueryHandler(ICompanyRepository companyRepository, IMapper mapper)
    {
        _companyRepository = companyRepository;
        _mapper = mapper;
    }

    public async Task<AllCompaniesResponse> Handle(GetAllCompaniesQuery request, CancellationToken cancellationToken)
    {
        var companies = await _companyRepository.GetAllAsync(cancellationToken);

        var allcompanies = _mapper.Map<AllCompaniesResponse>(companies);

        return allcompanies;
    }
}
