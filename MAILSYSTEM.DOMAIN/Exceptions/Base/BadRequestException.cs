using System.Runtime.Serialization;

namespace MAILSYSTEM.DOMAIN.Exceptions.Base;

[Serializable]
public abstract class BadRequestException : Exception
{
    protected BadRequestException()
    {
    }

    protected BadRequestException(string message)
        : base(message)
    {
    }

    protected BadRequestException(string message, Exception innerException)
        : base(message, innerException)
    {
    }

    // Without this constructor, deserialization will fail
    protected BadRequestException(SerializationInfo info, StreamingContext context)
        : base(info, context)
    {
    }
}
