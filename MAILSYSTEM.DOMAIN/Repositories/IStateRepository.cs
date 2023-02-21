using MAILSYSTEM.DOMAIN.Entities;

namespace MAILSYSTEM.DOMAIN.Repositories;

public interface IStateRepository
{
    Task<State?> GetByIdAsync(Guid id, CancellationToken cancellationToken = default);

    Task<State?> GetAllByName(string name, CancellationToken cancellationToken = default);
    Task<State?> GetAllByAbbreviation(string abbreviation, CancellationToken cancellationToken = default);

    Task<bool> IsNameUniqueAsync(string name, CancellationToken cancellationToken = default);
    Task<bool> IsAbbreviationUniqueAsync(string abbreviation, CancellationToken cancellationToken = default);
    Task<List<State>> GetAllAsync(CancellationToken cancellationToken = default);
    void Add(State item);
    void Update(State item);
}
