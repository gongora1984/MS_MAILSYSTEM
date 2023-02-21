using MAILSYSTEM.DOMAIN.Contracts.Responses.ListItems;

namespace MAILSYSTEM.APPLICATION.Persistence.ListItems.Queries.AllListItems;

public sealed class GetAllListItemQueryHandler : IRequestHandler<GetAllListItemQuery, AllListItemResponse>
{
    private readonly IListItemRepository _listItemRepository;
    private readonly IMapper _mapper;

    public GetAllListItemQueryHandler(IListItemRepository listItemRepository, IMapper mapper)
    {
        _listItemRepository = listItemRepository;
        _mapper = mapper;
    }

    public async Task<AllListItemResponse> Handle(GetAllListItemQuery request, CancellationToken cancellationToken)
    {
        var items = await _listItemRepository.GetAllAsync(cancellationToken);

        var allItems = _mapper.Map<AllListItemResponse>(items);

        return allItems;
    }
}
