using MAILSYSTEM.DOMAIN.Primitives;

namespace MAILSYSTEM.DOMAIN.Entities;

public partial class MailJob : Entity, IAuditableEntity
{
    //// public Guid MailJobId { get; set; }

    public Guid EnvelopTypeId { get; set; }

    public Guid CompanyId { get; set; }

    public string? MailJobKeyNumber { get; set; }

    public int? MailJobPages { get; set; }

    public int? MailJobCopies { get; set; }

    public decimal? MailJobTotalPostage { get; set; }

    public DateTime MailJobReceivedOn { get; set; }

    public DateTime? MailJobVerifiedOn { get; set; }

    public DateTime? MailJobPrintedOn { get; set; }

    public DateTime? MailJobSendOutOn { get; set; }

    public string MailJobDocumentNameOnly { get; set; } = null!;

    public string MailJobDocumentPath { get; set; } = null!;

    public string MailJobPropertyAddress1 { get; set; } = null!;

    public string? MailJobPropertyAddress2 { get; set; }

    public string MailJobMailJobPropertyCity { get; set; } = null!;

    public Guid MailJobPropertyState { get; set; }

    public string MailJobMailJobPropertyZip { get; set; } = null!;

    public bool MailJobVoided { get; set; }

    public string? MailJobCustomData1 { get; set; }

    public string? MailJobCustomData2 { get; set; }

    public string? MailJobCustomData3 { get; set; }

    public string? MailJobEnvelopeCaption1 { get; set; }

    public string? MailJobEnvelopeCaption2 { get; set; }

    public virtual Company Company { get; set; } = null!;

    public virtual ListItem EnvelopType { get; set; } = null!;

    public virtual ICollection<MailJobDetail> MailJobDetails { get; } = new List<MailJobDetail>();

    public virtual State MailJobPropertyStateNavigation { get; set; } = null!;
}
