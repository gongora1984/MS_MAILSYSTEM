using MAILSYSTEM.DOMAIN.Primitives;

namespace MAILSYSTEM.DOMAIN.Entities;

public partial class State : Entity, IAuditableEntity
{
    //// public Guid StateId { get; set; }

    public string StateAbbreviation { get; set; } = null!;

    public string StateDescription { get; set; } = null!;

    public virtual ICollection<Company> CompanyCompanyBillingStateNavigations { get; } = new List<Company>();

    public virtual ICollection<Company> CompanyCompanyReturnStateNavigations { get; } = new List<Company>();

    public virtual ICollection<Company> CompanyCompanyStateNavigations { get; } = new List<Company>();

    public virtual ICollection<MailJobDetail> MailJobDetailMailJobDetailChangedRecipientStateNavigations { get; } = new List<MailJobDetail>();

    public virtual ICollection<MailJobDetail> MailJobDetailRecipientStateNavigations { get; } = new List<MailJobDetail>();

    public virtual ICollection<MailJob> MailJobs { get; } = new List<MailJob>();
}
