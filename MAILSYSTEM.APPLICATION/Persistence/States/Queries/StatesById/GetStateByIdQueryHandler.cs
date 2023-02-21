using MAILSYSTEM.DOMAIN.Contracts.Responses.States;

namespace MAILSYSTEM.APPLICATION.Persistence.States.Queries.StatesById;

internal sealed class GetStateByIdQueryHandler : IQueryHandler<GetStateByIdQuery, StateResponse>
{
    private readonly IStateRepository _stateRepository;
    private readonly IMapper _mapper;

    public GetStateByIdQueryHandler(IStateRepository stateRepository, IMapper mapper)
    {
        _stateRepository = stateRepository;
        _mapper = mapper;
    }

    public async Task<Result<StateResponse>> Handle(GetStateByIdQuery request, CancellationToken cancellationToken)
    {
        var item = await _stateRepository.GetByIdAsync(request.stateId, cancellationToken);

        if (item is null)
        {
            return Result.Failure<StateResponse>(new Error(
                "State.NotFound",
                $"The state with id {request.stateId} was not found"));
        }

        var itemRtn = _mapper.Map<StateResponse>(item);

        return itemRtn;
    }
}
