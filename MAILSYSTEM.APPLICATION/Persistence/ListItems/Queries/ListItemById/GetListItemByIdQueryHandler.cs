using MAILSYSTEM.DOMAIN.Contracts.Responses.ListItems;

namespace MAILSYSTEM.APPLICATION.Persistence.ListItems.Queries.ListItemById;

internal sealed class GetListItemByIdQueryHandler : IQueryHandler<GetListItemByIdQuery, ListItemResponse>
{
    private readonly IListItemRepository _listItemRepository;
    private readonly IMapper _mapper;

    public GetListItemByIdQueryHandler(IListItemRepository listItemRepository, IMapper mapper)
    {
        _listItemRepository = listItemRepository;
        _mapper = mapper;
    }

    public async Task<Result<ListItemResponse>> Handle(GetListItemByIdQuery request, CancellationToken cancellationToken)
    {
        var item = await _listItemRepository.GetByIdAsync(request.listItemId, cancellationToken);

        var itemRtn = _mapper.Map<ListItemResponse>(item);

        return itemRtn;
    }
}
