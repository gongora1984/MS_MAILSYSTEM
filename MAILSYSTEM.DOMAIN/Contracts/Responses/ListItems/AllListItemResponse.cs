namespace MAILSYSTEM.DOMAIN.Contracts.Responses.ListItems;

public class AllListItemResponse
{
    public AllListItemResponse()
    {
    }

    public AllListItemResponse(IEnumerable<ListItemResponse> items)
    {
        Items = items;
        Count = items.Count();
    }

    public int Count { get; set; }
    public IEnumerable<ListItemResponse>? Items { get; set; }
}
