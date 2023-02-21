using MAILSYSTEM.DOMAIN.Contracts.Responses.ListItems;

namespace MAILSYSTEM.APPLICATION.Persistence.ListItems.Queries.ListItemByCategory;

internal sealed class GetListItemByCategoryQueryHandler : IQueryHandler<GetListItemByCategoryQuery, AllListItemResponse>
{
    private readonly IListItemRepository _listItemRepository;
    private readonly IMapper _mapper;

    public GetListItemByCategoryQueryHandler(IListItemRepository listItemRepository, IMapper mapper)
    {
        _listItemRepository = listItemRepository;
        _mapper = mapper;
    }

    public async Task<Result<AllListItemResponse>> Handle(GetListItemByCategoryQuery request, CancellationToken cancellationToken)
    {
        var items = await _listItemRepository.GetAllBySystemCategory(request.listItemCategory, cancellationToken);

        var itemsRtn = _mapper.Map<AllListItemResponse>(items);

        return itemsRtn;
    }
}
