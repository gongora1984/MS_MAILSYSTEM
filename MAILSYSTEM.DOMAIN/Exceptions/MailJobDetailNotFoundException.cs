using MAILSYSTEM.DOMAIN.Exceptions.Base;
using System.Runtime.Serialization;

namespace MAILSYSTEM.DOMAIN.Exceptions;

[Serializable]
public sealed class MailJobDetailNotFoundException : NotFoundException
{
    public MailJobDetailNotFoundException(Guid mailJobDetailId)
    : base($"The mail job detail with the identifier {mailJobDetailId} was not found.")
    {
    }

    private MailJobDetailNotFoundException(SerializationInfo serializationInfo, StreamingContext streamingContext)
        : base(serializationInfo, streamingContext)
    {
    }
}
