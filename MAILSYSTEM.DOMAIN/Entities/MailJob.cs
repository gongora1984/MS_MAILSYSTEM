using MAILSYSTEM.DOMAIN.Primitives;

namespace MAILSYSTEM.DOMAIN.Entities;

public partial class MailJob : Entity, IAuditableEntity
{
    //// public Guid MailJobId { get; set; }

    public Guid EnvelopTypeId { get; set; }

    public Guid CompanyId { get; set; }

    public string? KeyNumber { get; set; }

    public int? Pages { get; set; }

    public int? Copies { get; set; }

    public decimal? TotalPostage { get; set; }

    public DateTime ReceivedOn { get; set; }

    public DateTime? VerifiedOn { get; set; }

    public DateTime? PrintedOn { get; set; }

    public DateTime? SendOutOn { get; set; }

    public string DocumentNameOnly { get; set; } = null!;

    public string DocumentPath { get; set; } = null!;

    public string PropertyAddress1 { get; set; } = null!;

    public string? PropertyAddress2 { get; set; }

    public string PropertyCity { get; set; } = null!;

    public Guid PropertyState { get; set; }

    public string PropertyZip { get; set; } = null!;

    public bool Voided { get; set; }

    public string? CustomData1 { get; set; }

    public string? CustomData2 { get; set; }

    public string? CustomData3 { get; set; }

    public string? EnvelopeCaption1 { get; set; }

    public string? EnvelopeCaption2 { get; set; }

    public virtual Company Company { get; set; } = null!;

    public virtual ListItem EnvelopType { get; set; } = null!;

    public virtual ICollection<MailJobDetail> MailJobDetails { get; } = new List<MailJobDetail>();

    public virtual State MailJobPropertyStateNavigation { get; set; } = null!;
}
