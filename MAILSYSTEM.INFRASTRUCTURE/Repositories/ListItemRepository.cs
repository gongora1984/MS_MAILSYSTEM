using MAILSYSTEM.DOMAIN.Repositories;

namespace MAILSYSTEM.INFRASTRUCTURE.Repositories;

/// <summary>
/// ListItem Repository Implementation.
/// </summary>
public sealed class ListItemRepository : IListItemRepository
{
    private readonly ApplicationDbContext _dbContext;

    public ListItemRepository(ApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public void Add(ListItem item) =>
        _dbContext.Set<ListItem>().Add(item);

    public async Task<List<ListItem>> GetAllAsync(CancellationToken cancellationToken = default) =>
        await _dbContext
            .Set<ListItem>()
            .ToListAsync(cancellationToken);

    public async Task<List<ListItem>?> GetAllBySystemCategory(string systemCategory, CancellationToken cancellationToken = default) =>
        await _dbContext
            .Set<ListItem>()
            .Where(item => item.SystemCategory == systemCategory)
            .ToListAsync(cancellationToken);

    public async Task<List<ListItem>?> GetAllBySystemTag(string systemTag, CancellationToken cancellationToken = default) =>
        await _dbContext
            .Set<ListItem>()
            .Where(item => item.SystemTag == systemTag)
            .ToListAsync(cancellationToken);

    public async Task<ListItem?> GetByIdAsync(Guid id, CancellationToken cancellationToken = default) =>
        await _dbContext
            .Set<ListItem>()
            .FirstOrDefaultAsync(item => item.Id == id, cancellationToken);

    public async Task<bool> IsSystemCategoryUniqueAsync(string systemCategory, CancellationToken cancellationToken = default) =>
        !await _dbContext
            .Set<ListItem>()
            .AnyAsync(item => item.SystemCategory == systemCategory, cancellationToken);

    public async Task<bool> IsSystemItemUniqueAsync(string systemCategory, string systemTag, string displayText, CancellationToken cancellationToken = default) =>
        !await _dbContext
            .Set<ListItem>()
            .AnyAsync(item => item.SystemCategory == systemCategory && item.SystemTag == systemTag && item.ListItemDisplayText == displayText, cancellationToken);

    public async Task<bool> IsSystemTagUniqueAsync(string systemCategory, string systemTag, CancellationToken cancellationToken = default) =>
        !await _dbContext
            .Set<ListItem>()
            .AnyAsync(item => item.SystemCategory == systemCategory && item.SystemTag == systemTag, cancellationToken);

    public void Update(ListItem item) =>
        _dbContext.Set<ListItem>().Update(item);
}
