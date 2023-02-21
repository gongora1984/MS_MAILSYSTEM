namespace MAILSYSTEM.INFRASTRUCTURE.Configurations;

internal sealed class StateConfiguration : IEntityTypeConfiguration<State>
{
    public void Configure(EntityTypeBuilder<State> entity)
    {
        entity.HasKey(e => e.Id).HasName("PKState");

        entity.ToTable(TableNames.State);

        entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

        entity.Property(e => e.StateAbbreviation)
            .HasMaxLength(2)
            .IsUnicode(false);

        entity.Property(e => e.StateDescription)
            .HasMaxLength(50)
            .IsUnicode(false);
    }
}
