using System.Diagnostics.CodeAnalysis;

namespace MAILSYSTEM.DOMAIN.Primitives;

public abstract class Entity : IEqualityComparer<Entity>
{
    protected Entity()
    {
    }

    public Guid Id { get; set; }
    public DateTime CreatedOnUtc { get; set; }
    public DateTime? ModifiedOnUtc { get; set; }

    public bool Equals(Entity? first, Entity? second) =>
        first is not null && second is not null && first.Equals(second);
    public int GetHashCode([DisallowNull] Entity obj)
    {
        return Id.GetHashCode() * new Random().Next(100);
    }
}
