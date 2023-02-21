using MAILSYSTEM.DOMAIN.Entities;

namespace MAILSYSTEM.DOMAIN.Repositories;

public interface ICompanyRepository
{
    Task<Company?> GetByIdAsync(Guid id, CancellationToken cancellationToken = default);

    Task<Company?> GetByEmailAsync(string email, CancellationToken cancellationToken = default);

    Task<Company?> GetByNameAsync(string name, CancellationToken cancellationToken = default);

    Task<List<Company>> GetAllAsync(CancellationToken cancellationToken = default);

    Task<bool> IsEmailUniqueAsync(string email, CancellationToken cancellationToken = default);
    Task<bool> IsNameUniqueAsync(string name, CancellationToken cancellationToken = default);

    Task<bool> IsValidCredentialAsync(string email, string password, CancellationToken cancellationToken = default);

    void Add(Company company);

    void Update(Company company);
}
