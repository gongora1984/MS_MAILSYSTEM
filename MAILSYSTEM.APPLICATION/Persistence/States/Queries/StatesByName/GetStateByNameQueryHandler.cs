using MAILSYSTEM.DOMAIN.Contracts.Responses.States;

namespace MAILSYSTEM.APPLICATION.Persistence.States.Queries.StatesByName;

internal sealed class GetStateByNameQueryHandler : IQueryHandler<GetStateByNameQuery, StateResponse>
{
    private readonly IStateRepository _stateRepository;
    private readonly IMapper _mapper;

    public GetStateByNameQueryHandler(IStateRepository stateRepository, IMapper mapper)
    {
        _stateRepository = stateRepository;
        _mapper = mapper;
    }

    public async Task<Result<StateResponse>> Handle(GetStateByNameQuery request, CancellationToken cancellationToken)
    {
        var item = await _stateRepository.GetAllByName(request.name, cancellationToken);

        if (item is null)
        {
            return Result.Failure<StateResponse>(new Error(
                "State.NotFound",
                $"The state with name {request.name} was not found"));
        }

        var itemRtn = _mapper.Map<StateResponse>(item);

        return itemRtn;
    }
}
