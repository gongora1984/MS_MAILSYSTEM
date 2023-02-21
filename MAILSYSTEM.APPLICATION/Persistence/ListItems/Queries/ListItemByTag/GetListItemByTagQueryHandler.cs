using MAILSYSTEM.DOMAIN.Contracts.Responses.ListItems;

namespace MAILSYSTEM.APPLICATION.Persistence.ListItems.Queries.ListItemByTag;

internal sealed class GetListItemByTagQueryHandler : IQueryHandler<GetListItemByTagQuery, AllListItemResponse>
{
    private readonly IListItemRepository _listItemRepository;
    private readonly IMapper _mapper;

    public GetListItemByTagQueryHandler(IListItemRepository listItemRepository, IMapper mapper)
    {
        _listItemRepository = listItemRepository;
        _mapper = mapper;
    }

    public async Task<Result<AllListItemResponse>> Handle(GetListItemByTagQuery request, CancellationToken cancellationToken)
    {
        var items = await _listItemRepository.GetAllBySystemTag(request.listItemTag, cancellationToken);

        var itemsRtn = _mapper.Map<AllListItemResponse>(items);

        return itemsRtn;
    }
}
