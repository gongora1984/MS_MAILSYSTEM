namespace MAILSYSTEM.DOMAIN.Abstractions;

public interface ISecurityProvider
{
    string Hash(string password);

    bool Verify(string passwordHash, string inputPassword);
}
