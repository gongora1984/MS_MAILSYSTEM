using MAILSYSTEM.DOMAIN.Contracts.Responses.States;

namespace MAILSYSTEM.APPLICATION.Persistence.States.Queries.StatesByAbbreviation;

internal sealed class GetStateByAbbreviationQueryHandler : IQueryHandler<GetStateByAbbreviationQuery, StateResponse>
{
    private readonly IStateRepository _stateRepository;
    private readonly IMapper _mapper;

    public GetStateByAbbreviationQueryHandler(IStateRepository stateRepository, IMapper mapper)
    {
        _stateRepository = stateRepository;
        _mapper = mapper;
    }

    public async Task<Result<StateResponse>> Handle(GetStateByAbbreviationQuery request, CancellationToken cancellationToken)
    {
        var item = await _stateRepository.GetAllByAbbreviation(request.abbreviation, cancellationToken);

        if (item is null)
        {
            return Result.Failure<StateResponse>(new Error(
                "State.NotFound",
                $"The state with abbreviation {request.abbreviation} was not found"));
        }

        var itemRtn = _mapper.Map<StateResponse>(item);

        return itemRtn;
    }
}
