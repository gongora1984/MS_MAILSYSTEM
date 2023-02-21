using MAILSYSTEM.DOMAIN.Primitives;

namespace MAILSYSTEM.DOMAIN.Entities;

public partial class ListItem : Entity, IAuditableEntity
{
    //// public Guid ListItemid { get; set; }

    public string SystemCategory { get; set; } = null!;

    public string SystemTag { get; set; } = null!;

    public string ListItemDisplayText { get; set; } = null!;

    public int ListItemOrder { get; set; }

    public bool? ListItemEnable { get; set; }

    public virtual ICollection<MailJob> MailJobs { get; } = new List<MailJob>();
}
