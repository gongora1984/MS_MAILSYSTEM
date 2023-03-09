using MAILSYSTEM.DOMAIN.Abstractions;
using System.Security.Cryptography;

namespace MAILSYSTEM.INFRASTRUCTURE.Security;

internal sealed class SecurityProvider : ISecurityProvider
{
    private const int SaltSize = 128 / 8;
    private const int KeySize = 256 / 8;
    private const int Iterations = 10000;
    private const char Delimiter = ';';
    private static readonly HashAlgorithmName _hashAlgorithm = HashAlgorithmName.SHA256;
    public string Hash(string password)
    {
        var salt = RandomNumberGenerator.GetBytes(SaltSize);
        var hash = Rfc2898DeriveBytes.Pbkdf2(password, salt, Iterations, _hashAlgorithm, KeySize);

        return string.Join(Delimiter, Convert.ToBase64String(salt), Convert.ToBase64String(hash));
    }

    public bool Verify(string passwordHash, string inputPassword)
    {
        var elements = passwordHash.Split(Delimiter);

        var salt = Convert.FromBase64String(elements[0]);
        var hash = Convert.FromBase64String(elements[1]);

        var hashInput = Rfc2898DeriveBytes.Pbkdf2(inputPassword, salt, Iterations, _hashAlgorithm, KeySize);

        return CryptographicOperations.FixedTimeEquals(hash, hashInput);
    }
}
