using MAILSYSTEM.DOMAIN.Primitives;

namespace MAILSYSTEM.DOMAIN.Entities;

public partial class State : Entity, IAuditableEntity
{
    //// public Guid StateId { get; set; }

    public string StateAbbreviation { get; set; } = null!;

    public string StateDescription { get; set; } = null!;

    public virtual ICollection<Company> CompanyBillingStateNavigations { get; } = new List<Company>();

    public virtual ICollection<Company> CompanyReturnStateNavigations { get; } = new List<Company>();

    public virtual ICollection<Company> CompanyStateNavigations { get; } = new List<Company>();

    public virtual ICollection<MailJobDetail> ChangedRecipientStateNavigations { get; } = new List<MailJobDetail>();

    public virtual ICollection<MailJobDetail> RecipientStateNavigations { get; } = new List<MailJobDetail>();

    public virtual ICollection<MailJob> MailJobs { get; } = new List<MailJob>();
}
