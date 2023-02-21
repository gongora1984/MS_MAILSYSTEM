using MAILSYSTEM.DOMAIN.Primitives;

namespace MAILSYSTEM.DOMAIN.Entities;

public partial class CompanyLogin : Entity, IAuditableEntity
{
    //// public Guid CompanyLoginId { get; set; }

    public Guid CompanyId { get; set; }

    public string? CompanyAccessToken { get; set; }

    public DateTime? CompanyLastAccess { get; set; }

    public virtual Company Company { get; set; } = null!;
}
