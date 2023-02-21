namespace MAILSYSTEM.DOMAIN.Contracts.Responses.Companies;

public class AllCompaniesResponse
{
    public AllCompaniesResponse()
    {
    }

    public AllCompaniesResponse(IEnumerable<CompanyResponse> items)
    {
        Items = items;
        Count = items.Count();
    }

    public int Count { get; set; }
    public IEnumerable<CompanyResponse>? Items { get; set; }
}
