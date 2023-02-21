using MAILSYSTEM.DOMAIN.Exceptions.Base;
using System.Runtime.Serialization;

namespace MAILSYSTEM.DOMAIN.Exceptions;

[Serializable]
public sealed class MailJobNotFoundException : NotFoundException
{
    public MailJobNotFoundException(Guid mailJobId)
        : base($"The mail job with the identifier {mailJobId} was not found.")
    {
    }

    private MailJobNotFoundException(SerializationInfo serializationInfo, StreamingContext streamingContext)
        : base(serializationInfo, streamingContext)
    {
    }
}
