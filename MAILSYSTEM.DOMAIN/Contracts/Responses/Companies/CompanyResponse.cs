namespace MAILSYSTEM.DOMAIN.Contracts.Responses.Companies;

public class CompanyResponse
{
    public Guid Id { get; set; }

    public string CompanyName { get; set; } = null!;

    public string CompanyUsername { get; set; } = null!;

    public string CompanyPassword { get; set; } = null!;

    public string CompanyAddress1 { get; set; } = null!;

    public string? CompanyAddress2 { get; set; }

    public string CompanyCity { get; set; } = null!;

    public Guid CompanyState { get; set; }

    public string CompanyZip { get; set; } = null!;

    public string? CompanyPhone { get; set; }

    public string? CompanyFax { get; set; }

    public string? CompanyEmail { get; set; }

    public string CompanyBillingAddress1 { get; set; } = null!;

    public string? CompanyBillingAddress2 { get; set; }

    public string CompanyBillingCity { get; set; } = null!;

    public Guid CompanyBillingState { get; set; }

    public string CompanyBillingZip { get; set; } = null!;

    public string? CompanyReturnName { get; set; }

    public string? CompanyReturnAddress1 { get; set; }

    public string? CompanyReturnAddress2 { get; set; }

    public string? CompanyReturnCity { get; set; }

    public Guid? CompanyReturnState { get; set; }

    public string? CompanyReturnZip { get; set; }

    public string? CompanyReturnEmailAddress { get; set; }

    public string? CompanyDefaultFilePathLocation { get; set; }
}
