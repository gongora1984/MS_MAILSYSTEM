namespace MAILSYSTEM.INFRASTRUCTURE.Configurations;

internal sealed class MailJobDetailConfiguration : IEntityTypeConfiguration<MailJobDetail>
{
    public void Configure(EntityTypeBuilder<MailJobDetail> entity)
    {
        entity.HasKey(e => e.Id).HasName("PKMailJobDetail");

        entity.ToTable(TableNames.MailJobDetail);

        entity.HasIndex(e => e.MailJobId, "FKMailJobMailJobDetail");

        entity.HasIndex(e => e.ChangedRecipientState, "FKStateMailJobDetailChangedRecipientState");

        entity.HasIndex(e => e.RecipientState, "FKStateMailJobDetailRecipientState");

        entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
        entity.Property(e => e.ChangedRecipientAddress1)
            .HasMaxLength(250)
            .IsUnicode(false);

        entity.Property(e => e.ChangedRecipientAddress2)
            .HasMaxLength(200)
            .IsUnicode(false);

        entity.Property(e => e.ChangedRecipientCity)
            .HasMaxLength(50)
            .IsUnicode(false);

        entity.Property(e => e.ChangedRecipientName)
            .HasMaxLength(350)
            .IsUnicode(false);

        entity.Property(e => e.ChangedRecipientZip)
            .HasMaxLength(15)
            .IsUnicode(false);

        entity.Property(e => e.NotSentNote)
            .HasMaxLength(1500)
            .IsUnicode(false);

        entity.Property(e => e.PostageAmount).HasColumnType("decimal(16, 3)");

        entity.Property(e => e.ReceivedOn).HasDefaultValueSql("(getdate())");

        entity.Property(e => e.TrackingNumber)
            .HasMaxLength(150)
            .IsUnicode(false);

        entity.Property(e => e.RecipientAddress1)
            .HasMaxLength(250)
            .IsUnicode(false);

        entity.Property(e => e.RecipientAddress2)
            .HasMaxLength(200)
            .IsUnicode(false);

        entity.Property(e => e.RecipientCity)
            .HasMaxLength(50)
            .IsUnicode(false);

        entity.Property(e => e.RecipientName)
            .HasMaxLength(350)
            .IsUnicode(false);

        entity.Property(e => e.RecipientZip)
            .HasMaxLength(15)
            .IsUnicode(false);

        entity.HasOne(d => d.ChangedRecipientStateNavigation).WithMany(p => p.ChangedRecipientStateNavigations)
            .HasForeignKey(d => d.ChangedRecipientState)
            .HasConstraintName("FKStateMailJobDetailChangedRecipientState");

        entity.HasOne(d => d.MailJob).WithMany(p => p.MailJobDetails)
            .HasForeignKey(d => d.MailJobId)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FKMailJobMailJobDetail");

        entity.HasOne(d => d.RecipientStateNavigation).WithMany(p => p.RecipientStateNavigations)
            .HasForeignKey(d => d.RecipientState)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FKStateMailJobDetailRecipientState");
    }
}
