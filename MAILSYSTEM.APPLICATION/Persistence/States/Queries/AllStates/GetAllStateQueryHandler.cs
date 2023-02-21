using MAILSYSTEM.DOMAIN.Contracts.Responses.States;

namespace MAILSYSTEM.APPLICATION.Persistence.States.Queries.AllStates;

public sealed class GetAllStateQueryHandler : IRequestHandler<GetAllStateQuery, AllStateResponse>
{
    private readonly IStateRepository _stateRepository;
    private readonly IMapper _mapper;

    public GetAllStateQueryHandler(IStateRepository stateRepository, IMapper mapper)
    {
        _stateRepository = stateRepository;
        _mapper = mapper;
    }

    public async Task<AllStateResponse> Handle(GetAllStateQuery request, CancellationToken cancellationToken)
    {
        var items = await _stateRepository.GetAllAsync(cancellationToken);

        var allItems = _mapper.Map<AllStateResponse>(items);

        return allItems;
    }
}
