namespace MAILSYSTEM.DOMAIN.Contracts.Responses.MailingItems;

public class AllMailingItemResponse
{
    public AllMailingItemResponse()
    {
    }

    public AllMailingItemResponse(IEnumerable<MailingItemResponse> items)
    {
        Items = items;
        Count = items.Count();
    }

    public int Count { get; set; }
    public IEnumerable<MailingItemResponse>? Items { get; set; }
}
