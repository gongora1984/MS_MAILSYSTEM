using MAILSYSTEM.DOMAIN.Abstractions;
using MAILSYSTEM.DOMAIN.Primitives;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace MAILSYSTEM.INFRASTRUCTURE;

/// <summary>
/// Unit Of Work Interface Implementation.
/// </summary>
internal sealed class UnitOfWork : IUnitOfWork
{
    private readonly ApplicationDbContext _dbContext;

    public UnitOfWork(ApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    /// <summary>
    /// Save changes to the database.
    /// </summary>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public Task SaveChangesAsync(CancellationToken cancellationToken = default)
    {
        UpdateAuditableEntities();

        return _dbContext.SaveChangesAsync(cancellationToken);
    }

    /// <summary>
    /// Update Auditable Entities on add or update.
    /// </summary>
    private void UpdateAuditableEntities()
    {
        IEnumerable<EntityEntry<IAuditableEntity>> entries =
            _dbContext
                .ChangeTracker
                .Entries<IAuditableEntity>();

        foreach (EntityEntry<IAuditableEntity> entityEntry in entries)
        {
            if (entityEntry.State == EntityState.Added)
            {
                entityEntry.Property(a => a.CreatedOnUtc)
                    .CurrentValue = DateTime.UtcNow;
            }

            if (entityEntry.State == EntityState.Modified)
            {
                entityEntry.Property(a => a.ModifiedOnUtc)
                    .CurrentValue = DateTime.UtcNow;
            }
        }
    }
}
