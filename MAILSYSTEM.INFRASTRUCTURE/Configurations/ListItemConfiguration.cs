namespace MAILSYSTEM.INFRASTRUCTURE.Configurations;

internal sealed class ListItemConfiguration : IEntityTypeConfiguration<ListItem>
{
    public void Configure(EntityTypeBuilder<ListItem> entity)
    {
        entity.HasKey(e => e.Id).HasName("PKListItem");

        entity.ToTable(TableNames.ListItem);

        entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

        entity.Property(e => e.ListItemDisplayText)
            .HasMaxLength(150)
            .IsUnicode(false);

        entity.Property(e => e.ListItemEnable)
            .IsRequired()
            .HasDefaultValueSql("((1))");

        entity.Property(e => e.SystemCategory)
            .HasMaxLength(50)
            .IsUnicode(false);

        entity.Property(e => e.SystemTag)
            .HasMaxLength(50)
            .IsUnicode(false);
    }
}
