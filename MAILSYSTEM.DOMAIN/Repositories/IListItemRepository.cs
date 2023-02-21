using MAILSYSTEM.DOMAIN.Entities;

namespace MAILSYSTEM.DOMAIN.Repositories;

/// <summary>
/// ListItem Repository Interface.
/// </summary>
public interface IListItemRepository
{
    Task<ListItem?> GetByIdAsync(Guid id, CancellationToken cancellationToken = default);
    Task<List<ListItem>?> GetAllBySystemCategory(string systemCategory, CancellationToken cancellationToken = default);
    Task<List<ListItem>?> GetAllBySystemTag(string systemTag, CancellationToken cancellationToken = default);
    Task<List<ListItem>> GetAllAsync(CancellationToken cancellationToken = default);
    Task<bool> IsSystemCategoryUniqueAsync(string systemCategory, CancellationToken cancellationToken = default);
    Task<bool> IsSystemTagUniqueAsync(string systemCategory, string systemTag, CancellationToken cancellationToken = default);
    Task<bool> IsSystemItemUniqueAsync(string systemCategory, string systemTag, string displayText, CancellationToken cancellationToken = default);
    void Add(ListItem item);
    void Update(ListItem item);
}
