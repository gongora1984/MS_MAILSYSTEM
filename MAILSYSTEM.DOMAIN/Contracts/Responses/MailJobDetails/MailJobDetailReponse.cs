namespace MAILSYSTEM.DOMAIN.Contracts.Responses.MailJobDetails;

public class MailJobDetailReponse
{
    public Guid Id { get; set; }

    public Guid MailJobId { get; set; }

    public string RecipientName { get; set; } = null!;

    public string RecipientAddress1 { get; set; } = null!;

    public string? RecipientAddress2 { get; set; }

    public string RecipientCity { get; set; } = null!;

    public Guid RecipientState { get; set; }

    public string RecipientZip { get; set; } = null!;

    public DateTime ReceivedOn { get; set; }

    public decimal? PostageAmount { get; set; }
}
