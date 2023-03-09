using MAILSYSTEM.DOMAIN.Abstractions;
using MAILSYSTEM.DOMAIN.Errors;

namespace MAILSYSTEM.APPLICATION.Persistence.Companies.Commands.CreateCompany;

internal sealed class CreateCompanyCommandHandler : ICommandHandler<CreateCompanyCommand, string>
{
    private readonly IApiProvider _apiProvider;
    private readonly ICompanyRepository _companyRepository;
    private readonly ICommonRepository _generalRepository;
    private readonly ISecurityProvider _securityProvider;
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public CreateCompanyCommandHandler(
        IApiProvider apiProvider,
        ICompanyRepository companyRepository,
        IUnitOfWork unitOfWork,
        IMapper mapper,
        ICommonRepository generalRepository,
        ISecurityProvider securityProvider)
    {
        _apiProvider = apiProvider;
        _companyRepository = companyRepository;
        _unitOfWork = unitOfWork;
        _mapper = mapper;
        _generalRepository = generalRepository;
        _securityProvider = securityProvider;
    }

    public async Task<Result<string>> Handle(CreateCompanyCommand request, CancellationToken cancellationToken)
    {
        if (!await _companyRepository.IsEmailUniqueAsync(request.company.companyEmail, cancellationToken))
        {
            return Result.Failure<string>(DomainErrors.Company.CompanyUsernameInUse);
        }

        if (!await _companyRepository.IsNameUniqueAsync(request.company.companyName, cancellationToken))
        {
            return Result.Failure<string>(DomainErrors.Company.CompanyNameInUse);
        }

        State? stateInfo = request.company.companyState.Length == 2 ?
            await _generalRepository.GetStateByAbbreviationAsync(request.company.companyState.ToString()) :
            await _generalRepository.GetStateByNameAsync(request.company.companyState.ToString());

        if (stateInfo is null)
        {
            return request.company.companyState.Length == 2 ?
                Result.Failure<string>(DomainErrors.State.NotFoundByAbbreviation(request.company.companyState)) :
                Result.Failure<string>(DomainErrors.State.NotFoundByName(request.company.companyState));
        }

        State? stateInfoBilling = request.company.companyBillingState.Length == 2 ?
            await _generalRepository.GetStateByAbbreviationAsync(request.company.companyBillingState.ToString()) :
            await _generalRepository.GetStateByNameAsync(request.company.companyBillingState.ToString());

        if (stateInfoBilling is null)
        {
            return request.company.companyBillingState.Length == 2 ?
                Result.Failure<string>(DomainErrors.State.NotFoundByAbbreviationBilling(request.company.companyBillingState)) :
                Result.Failure<string>(DomainErrors.State.NotFoundByNameBilling(request.company.companyBillingState));
        }

        var companyReturnState = request.company.companyReturnState;
        if (!string.IsNullOrEmpty(request.company.companyReturnState))
        {
            State? stateInfoReturn = request.company.companyReturnState.Length == 2 ?
            await _generalRepository.GetStateByAbbreviationAsync(request.company.companyReturnState.ToString()) :
            await _generalRepository.GetStateByNameAsync(request.company.companyReturnState.ToString());

            if (stateInfoReturn is null)
            {
                return request.company.companyReturnState.Length == 2 ?
                    Result.Failure<string>(DomainErrors.State.NotFoundByAbbreviationReturn(request.company.companyReturnState)) :
                    Result.Failure<string>(DomainErrors.State.NotFoundByNameReturn(request.company.companyReturnState));
            }
            else
            {
                companyReturnState = stateInfoReturn.Id.ToString();
            }
        }

        var requestCompany = request.company with
        {
            companyState = stateInfo.Id.ToString(),
            companyBillingState = stateInfoBilling.Id.ToString(),
            companyReturnState = companyReturnState,
            companyPassword = _securityProvider.Hash(request.company.companyPassword)
        };

        var newCompany = _mapper.Map<Company>(requestCompany);

        _companyRepository.Add(newCompany);

        await _unitOfWork.SaveChangesAsync(cancellationToken);

        _apiProvider.GenerateApiKey(newCompany);

        return newCompany.Id.ToString();
    }
}
