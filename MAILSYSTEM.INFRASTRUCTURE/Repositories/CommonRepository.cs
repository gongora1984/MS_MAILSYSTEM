using MAILSYSTEM.DOMAIN.Repositories;

namespace MAILSYSTEM.INFRASTRUCTURE.Repositories;

public sealed class CommonRepository : ICommonRepository
{
    private readonly ApplicationDbContext _dbContext;

    public CommonRepository(ApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<State?> GetStateByAbbreviationAsync(string stateAbbreviation, CancellationToken cancellationToken = default) =>
        await _dbContext
            .Set<State>()
            .FirstOrDefaultAsync(state => state.StateAbbreviation == stateAbbreviation, cancellationToken);

    public async Task<State?> GetStateByIdAsync(Guid id, CancellationToken cancellationToken = default) =>
        await _dbContext
            .Set<State>()
            .FirstOrDefaultAsync(state => state.Id == id, cancellationToken);

    public async Task<State?> GetStateByNameAsync(string stateName, CancellationToken cancellationToken = default) =>
    await _dbContext
    .Set<State>()
            .FirstOrDefaultAsync(state => state.StateDescription == stateName, cancellationToken);
}
