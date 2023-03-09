using MAILSYSTEM.DOMAIN.Repositories;

namespace MAILSYSTEM.INFRASTRUCTURE.Repositories;

public sealed class CompanyRepository : ICompanyRepository
{
    private readonly ApplicationDbContext _dbContext;

    public CompanyRepository(ApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public void Add(Company company) =>
        _dbContext.Set<Company>().Add(company);

    public async Task<List<Company>> GetAllAsync(CancellationToken cancellationToken = default) =>
        await _dbContext
            .Set<Company>()
            .ToListAsync(cancellationToken);

    public async Task<CompanyLogin?> GetApiKeyByCompanyIdAsync(Guid id, CancellationToken cancellationToken = default) =>
        await _dbContext
            .Set<CompanyLogin>()
            .FirstOrDefaultAsync(c => c.CompanyId == id, cancellationToken);

    public async Task<Company?> GetByEmailAsync(string email, CancellationToken cancellationToken = default) =>
        await _dbContext
            .Set<Company>()
            .FirstOrDefaultAsync(company => company.CompanyUsername == email, cancellationToken);

    public async Task<Company?> GetByIdAsync(Guid id, CancellationToken cancellationToken = default) =>
        await _dbContext
            .Set<Company>()
            .FirstOrDefaultAsync(company => company.Id == id, cancellationToken);

    public async Task<Company?> GetByNameAsync(string name, CancellationToken cancellationToken = default) =>
        await _dbContext
            .Set<Company>()
            .FirstOrDefaultAsync(company => company.CompanyName == name, cancellationToken);

    public async Task<bool> IsEmailUniqueAsync(string email, CancellationToken cancellationToken = default) =>
        !await _dbContext
            .Set<Company>()
            .AnyAsync(company => company.CompanyUsername == email, cancellationToken);

    public async Task<bool> IsNameUniqueAsync(string name, CancellationToken cancellationToken = default) =>
        !await _dbContext
            .Set<Company>()
            .AnyAsync(company => company.CompanyName == name, cancellationToken);

    public async Task<bool> IsValidCredentialAsync(string email, string password, CancellationToken cancellationToken = default) =>
        !await _dbContext
            .Set<Company>()
            .AnyAsync(company => company.CompanyUsername == email && company.CompanyPassword == password, cancellationToken);

    public void Update(Company company) =>
        _dbContext.Set<Company>().Update(company);
}
