using MAILSYSTEM.DOMAIN.Repositories;

namespace MAILSYSTEM.INFRASTRUCTURE.Repositories;

public sealed class StateRepository : IStateRepository
{
    private readonly ApplicationDbContext _dbContext;

    public StateRepository(ApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public void Add(State item) =>
        _dbContext.Set<State>().Add(item);

    public async Task<List<State>> GetAllAsync(CancellationToken cancellationToken = default) =>
        await _dbContext
            .Set<State>()
            .ToListAsync(cancellationToken);

    public async Task<State?> GetAllByAbbreviation(string abbreviation, CancellationToken cancellationToken = default) =>
        await _dbContext
            .Set<State>()
            .FirstOrDefaultAsync(item => item.StateAbbreviation == abbreviation, cancellationToken);

    public async Task<State?> GetAllByName(string name, CancellationToken cancellationToken = default) =>
        await _dbContext
            .Set<State>()
            .FirstOrDefaultAsync(item => item.StateDescription == name, cancellationToken);

    public async Task<State?> GetByIdAsync(Guid id, CancellationToken cancellationToken = default) =>
        await _dbContext
            .Set<State>()
            .FirstOrDefaultAsync(item => item.Id == id, cancellationToken);

    public async Task<bool> IsAbbreviationUniqueAsync(string abbreviation, CancellationToken cancellationToken = default) =>
        !await _dbContext
            .Set<State>()
            .AnyAsync(item => item.StateAbbreviation == abbreviation, cancellationToken);

    public async Task<bool> IsNameUniqueAsync(string name, CancellationToken cancellationToken = default) =>
        !await _dbContext
            .Set<State>()
            .AnyAsync(item => item.StateDescription == name, cancellationToken);

    public void Update(State item) =>
        _dbContext.Set<State>().Update(item);
}
