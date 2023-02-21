using MAILSYSTEM.DOMAIN.Contracts.Responses.Companies;

namespace MAILSYSTEM.APPLICATION.Persistence.Companies.Queries.CompanyByName;

internal sealed class GetCompanyByNameQueryHandler : IQueryHandler<GetCompanyByNameQuery, CompanyResponse>
{
    private readonly ICompanyRepository _companyRepository;
    private readonly IMapper _mapper;

    public GetCompanyByNameQueryHandler(ICompanyRepository companyRepository, IMapper mapper)
    {
        _companyRepository = companyRepository;
        _mapper = mapper;
    }

    /// <summary>
    /// Get Company By Name handler.
    /// </summary>
    /// <param name="request"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public async Task<Result<CompanyResponse>> Handle(GetCompanyByNameQuery request, CancellationToken cancellationToken)
    {
        var company = await _companyRepository.GetByNameAsync(request.comanyName, cancellationToken);

        var companyrtn = _mapper.Map<CompanyResponse>(company);

        return companyrtn;
    }
}
