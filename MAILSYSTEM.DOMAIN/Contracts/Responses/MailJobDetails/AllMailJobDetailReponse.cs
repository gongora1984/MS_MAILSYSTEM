namespace MAILSYSTEM.DOMAIN.Contracts.Responses.MailJobDetails;

public class AllMailJobDetailReponse
{
    public AllMailJobDetailReponse()
    {
    }

    public AllMailJobDetailReponse(IEnumerable<MailJobDetailReponse> items)
    {
        Items = items;
        Count = items.Count();
    }

    public int Count { get; set; }
    public IEnumerable<MailJobDetailReponse>? Items { get; set; }
}
