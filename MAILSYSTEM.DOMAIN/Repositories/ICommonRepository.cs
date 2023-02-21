using MAILSYSTEM.DOMAIN.Entities;

namespace MAILSYSTEM.DOMAIN.Repositories;

public interface ICommonRepository
{
    Task<State?> GetStateByIdAsync(Guid id, CancellationToken cancellationToken = default);
    Task<State?> GetStateByNameAsync(string stateName, CancellationToken cancellationToken = default);
    Task<State?> GetStateByAbbreviationAsync(string stateAbbreviation, CancellationToken cancellationToken = default);
}
