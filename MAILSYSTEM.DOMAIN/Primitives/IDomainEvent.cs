using MediatR;

namespace MAILSYSTEM.DOMAIN.Primitives;

public interface IDomainEvent : INotification
{
    public Guid Id { get; init; }
}
