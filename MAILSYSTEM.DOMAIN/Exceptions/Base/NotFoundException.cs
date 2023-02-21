using System.Runtime.Serialization;

namespace MAILSYSTEM.DOMAIN.Exceptions.Base;

public abstract class NotFoundException : Exception
{
    protected NotFoundException()
    {
    }

    protected NotFoundException(string message)
        : base(message)
    {
    }

    protected NotFoundException(string message, Exception innerException)
        : base(message, innerException)
    {
    }

    // Without this constructor, deserialization will fail
    protected NotFoundException(SerializationInfo info, StreamingContext context)
        : base(info, context)
    {
    }
}
