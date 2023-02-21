using System.Reflection;

namespace MAILSYSTEM.INFRASTRUCTURE;

public static class AssemblyReference
{
    public static readonly Assembly Assembly = typeof(AssemblyReference).Assembly;
}
