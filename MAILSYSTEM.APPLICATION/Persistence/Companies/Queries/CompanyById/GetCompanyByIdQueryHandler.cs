using MAILSYSTEM.DOMAIN.Contracts.Responses.Companies;

namespace MAILSYSTEM.APPLICATION.Persistence.Companies.Queries.CompanyById;

internal sealed class GetCompanyByIdQueryHandler : IQueryHandler<GetCompanyByIdQuery, CompanyResponse>
{
    private readonly ICompanyRepository _companyRepository;
    private readonly IMapper _mapper;

    public GetCompanyByIdQueryHandler(ICompanyRepository companyRepository, IMapper mapper)
    {
        _companyRepository = companyRepository;
        _mapper = mapper;
    }

    /// <summary>
    /// Get Company By Id handler.
    /// </summary>
    /// <param name="request"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public async Task<Result<CompanyResponse>> Handle(GetCompanyByIdQuery request, CancellationToken cancellationToken)
    {
        var company = await _companyRepository.GetByIdAsync(request.companyId, cancellationToken);

        var companyrtn = _mapper.Map<CompanyResponse>(company);

        return companyrtn;
    }
}
