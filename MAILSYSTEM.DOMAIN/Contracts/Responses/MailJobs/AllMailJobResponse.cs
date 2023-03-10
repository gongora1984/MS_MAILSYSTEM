namespace MAILSYSTEM.DOMAIN.Contracts.Responses.MailJobs;

public class AllMailJobResponse
{
    public AllMailJobResponse()
    {
    }

    public AllMailJobResponse(IEnumerable<MailJobResponse> items)
    {
        Items = items;
        Count = items.Count();
    }

    public int Count { get; set; }
    public IEnumerable<MailJobResponse>? Items { get; set; }
}
