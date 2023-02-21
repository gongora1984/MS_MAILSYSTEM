namespace MAILSYSTEM.DOMAIN.Contracts.Responses.States;

public class AllStateResponse
{
    public AllStateResponse()
    {
    }

    public AllStateResponse(IEnumerable<StateResponse> items)
    {
        Items = items;
        Count = items.Count();
    }

    public int Count { get; set; }
    public IEnumerable<StateResponse>? Items { get; set; }
}
