using MAILSYSTEM.DOMAIN.Entities;

namespace MAILSYSTEM.DOMAIN.Abstractions;

public interface IApiProvider
{
    string GenerateApiKey(Company company);
}
