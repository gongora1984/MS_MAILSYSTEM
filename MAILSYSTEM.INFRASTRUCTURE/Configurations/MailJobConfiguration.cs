namespace MAILSYSTEM.INFRASTRUCTURE.Configurations;

internal sealed class MailJobConfiguration : IEntityTypeConfiguration<MailJob>
{
    public void Configure(EntityTypeBuilder<MailJob> entity)
    {
        entity.HasKey(e => e.Id).HasName("PKMailJob");

        entity.ToTable(TableNames.MailJob);

        entity.HasIndex(e => e.CompanyId, "FKCompanyMailJob");

        entity.HasIndex(e => e.EnvelopTypeId, "FKMailJobListItemEnvelopType");

        entity.HasIndex(e => e.PropertyState, "FKStatePropertyState");

        entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

        entity.Property(e => e.CustomData1)
            .HasMaxLength(150)
            .IsUnicode(false);

        entity.Property(e => e.CustomData2)
            .HasMaxLength(150)
            .IsUnicode(false);

        entity.Property(e => e.CustomData3)
            .HasMaxLength(150)
            .IsUnicode(false);

        entity.Property(e => e.DocumentNameOnly)
            .HasMaxLength(150)
            .IsUnicode(false);

        entity.Property(e => e.DocumentPath)
            .HasMaxLength(1500)
            .IsUnicode(false);

        entity.Property(e => e.EnvelopeCaption1)
            .HasMaxLength(250)
            .IsUnicode(false);

        entity.Property(e => e.EnvelopeCaption2)
            .HasMaxLength(250)
            .IsUnicode(false);

        entity.Property(e => e.KeyNumber)
            .HasMaxLength(50)
            .IsUnicode(false);

        entity.Property(e => e.PropertyCity)
            .HasMaxLength(50)
            .IsUnicode(false);

        entity.Property(e => e.PropertyZip)
            .HasMaxLength(15)
            .IsUnicode(false);

        entity.Property(e => e.PropertyAddress1)
            .HasMaxLength(250)
            .IsUnicode(false);

        entity.Property(e => e.PropertyAddress2)
            .HasMaxLength(200)
            .IsUnicode(false);

        entity.Property(e => e.TotalPostage).HasColumnType("decimal(16, 2)");

        entity.HasOne(d => d.Company).WithMany(p => p.MailJobs)
            .HasForeignKey(d => d.CompanyId)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FKCompanyMailJob");

        entity.HasOne(d => d.EnvelopType).WithMany(p => p.MailJobs)
            .HasForeignKey(d => d.EnvelopTypeId)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FKMailJobListItemEnvelopType");

        entity.HasOne(d => d.MailJobPropertyStateNavigation).WithMany(p => p.MailJobs)
            .HasForeignKey(d => d.PropertyState)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FKStateMailJobPropertyState");
    }
}
