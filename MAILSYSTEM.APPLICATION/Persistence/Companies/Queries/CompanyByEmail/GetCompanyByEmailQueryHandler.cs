using MAILSYSTEM.DOMAIN.Contracts.Responses.Companies;

namespace MAILSYSTEM.APPLICATION.Persistence.Companies.Queries.CompanyByEmail;

internal sealed class GetCompanyByEmailQueryHandler : IQueryHandler<GetCompanyByEmailQuery, CompanyResponse>
{
    private readonly ICompanyRepository _companyRepository;
    private readonly IMapper _mapper;

    public GetCompanyByEmailQueryHandler(ICompanyRepository companyRepository, IMapper mapper)
    {
        _companyRepository = companyRepository;
        _mapper = mapper;
    }

    /// <summary>
    /// Get Company By Email handler.
    /// </summary>
    /// <param name="request"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public async Task<Result<CompanyResponse>> Handle(GetCompanyByEmailQuery request, CancellationToken cancellationToken)
    {
        var company = await _companyRepository.GetByEmailAsync(request.companyEmail, cancellationToken);

        var companyrtn = _mapper.Map<CompanyResponse>(company);

        return companyrtn;
    }
}
