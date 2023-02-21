using MediatR;

namespace MAILSYSTEM.APPLICATION.Abstractions.Messaging;

public interface IQuery<TResponse> : IRequest<Result<TResponse>>
{
}
