namespace MAILSYSTEM.DOMAIN.Contracts.Responses.MailJobs;

public class MailJobResponse
{
    public Guid Id { get; set; }

    public Guid EnvelopTypeId { get; set; }

    public Guid CompanyId { get; set; }

    public string PropertyAddress1 { get; set; } = null!;

    public string? PropertyAddress2 { get; set; }

    public string PropertyCity { get; set; } = null!;

    public Guid PropertyState { get; set; }

    public string PropertyZip { get; set; } = null!;

    public int? Pages { get; set; }

    public int? Copies { get; set; }

    public decimal? TotalPostage { get; set; }

    public DateTime ReceivedOn { get; set; }

    public DateTime CreatedOnUtc { get; set; }
}
