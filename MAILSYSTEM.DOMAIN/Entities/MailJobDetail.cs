using MAILSYSTEM.DOMAIN.Primitives;

namespace MAILSYSTEM.DOMAIN.Entities;

public partial class MailJobDetail : Entity, IAuditableEntity
{
    //// public Guid MailJobDetailId { get; set; }

    public Guid MailJobId { get; set; }

    public string RecipientName { get; set; } = null!;

    public string RecipientAddress1 { get; set; } = null!;

    public string? RecipientAddress2 { get; set; }

    public string RecipientCity { get; set; } = null!;

    public Guid RecipientState { get; set; }

    public string RecipientZip { get; set; } = null!;

    public DateTime ReceivedOn { get; set; }

    public DateTime? VerifiedOn { get; set; }

    public DateTime? PrintedOn { get; set; }

    public DateTime? SentOutOn { get; set; }

    public decimal? PostageAmount { get; set; }

    public string? TrackingNumber { get; set; }

    public string? NotSentNote { get; set; }

    public bool Voided { get; set; }

    public bool WasCorrected { get; set; }

    public DateTime? CorrectedOn { get; set; }

    public string? ChangedRecipientName { get; set; }

    public string? ChangedRecipientAddress1 { get; set; }

    public string? ChangedRecipientAddress2 { get; set; }

    public string? ChangedRecipientCity { get; set; }

    public Guid? ChangedRecipientState { get; set; }

    public string? ChangedRecipientZip { get; set; }

    public bool WasReturned { get; set; }

    public DateTime? ReturnedOn { get; set; }

    public virtual MailJob MailJob { get; set; } = null!;

    public virtual State? ChangedRecipientStateNavigation { get; set; }

    public virtual State RecipientStateNavigation { get; set; } = null!;
}
