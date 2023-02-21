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

    public DateTime MailJobDetailReceivedOn { get; set; }

    public DateTime? MailJobDetailVerifiedOn { get; set; }

    public DateTime? MailJobDetailPrintedOn { get; set; }

    public DateTime? MailJobDetailSentOutOn { get; set; }

    public decimal? MailJobDetailPostageAmount { get; set; }

    public string? MailJobDetailTrackingNumber { get; set; }

    public string? MailJobDetailNotSentNote { get; set; }

    public bool MailJobDetailVoided { get; set; }

    public bool MailJobDetailWasCorrected { get; set; }

    public DateTime? MailJobDetailCorrectedOn { get; set; }

    public string? MailJobDetailChangedRecipientName { get; set; }

    public string? MailJobDetailChangedRecipientAddress1 { get; set; }

    public string? MailJobDetailChangedRecipientAddress2 { get; set; }

    public string? MailJobDetailChangedRecipientCity { get; set; }

    public Guid? MailJobDetailChangedRecipientState { get; set; }

    public string? MailJobDetailChangedRecipientZip { get; set; }

    public bool MailJobDetailWasReturned { get; set; }

    public DateTime? MailJobDetailReturnedOn { get; set; }

    public virtual MailJob MailJob { get; set; } = null!;

    public virtual State? MailJobDetailChangedRecipientStateNavigation { get; set; }

    public virtual State RecipientStateNavigation { get; set; } = null!;
}
