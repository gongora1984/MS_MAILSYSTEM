namespace MAILSYSTEM.INFRASTRUCTURE.Configurations;

internal sealed class MailJobConfiguration : IEntityTypeConfiguration<MailJob>
{
    public void Configure(EntityTypeBuilder<MailJob> entity)
    {
        entity.HasKey(e => e.Id).HasName("PKMailJob");

        entity.ToTable(TableNames.MailJob);

        entity.HasIndex(e => e.CompanyId, "FKCompanyMailJob");

        entity.HasIndex(e => e.EnvelopTypeId, "FKMailJobListItemEnvelopType");

        entity.HasIndex(e => e.MailJobPropertyState, "FKStateMailJobPropertyState");

        entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

        entity.Property(e => e.MailJobCustomData1)
            .HasMaxLength(150)
            .IsUnicode(false);

        entity.Property(e => e.MailJobCustomData2)
            .HasMaxLength(150)
            .IsUnicode(false);

        entity.Property(e => e.MailJobCustomData3)
            .HasMaxLength(150)
            .IsUnicode(false);

        entity.Property(e => e.MailJobDocumentNameOnly)
            .HasMaxLength(150)
            .IsUnicode(false);

        entity.Property(e => e.MailJobDocumentPath)
            .HasMaxLength(1500)
            .IsUnicode(false);

        entity.Property(e => e.MailJobEnvelopeCaption1)
            .HasMaxLength(250)
            .IsUnicode(false);

        entity.Property(e => e.MailJobEnvelopeCaption2)
            .HasMaxLength(250)
            .IsUnicode(false);

        entity.Property(e => e.MailJobKeyNumber)
            .HasMaxLength(50)
            .IsUnicode(false);

        entity.Property(e => e.MailJobMailJobPropertyCity)
            .HasMaxLength(50)
            .IsUnicode(false);

        entity.Property(e => e.MailJobMailJobPropertyZip)
            .HasMaxLength(15)
            .IsUnicode(false);

        entity.Property(e => e.MailJobPropertyAddress1)
            .HasMaxLength(250)
            .IsUnicode(false);

        entity.Property(e => e.MailJobPropertyAddress2)
            .HasMaxLength(200)
            .IsUnicode(false);

        entity.Property(e => e.MailJobTotalPostage).HasColumnType("decimal(16, 2)");

        entity.HasOne(d => d.Company).WithMany(p => p.MailJobs)
            .HasForeignKey(d => d.CompanyId)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FKCompanyMailJob");

        entity.HasOne(d => d.EnvelopType).WithMany(p => p.MailJobs)
            .HasForeignKey(d => d.EnvelopTypeId)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FKMailJobListItemEnvelopType");

        entity.HasOne(d => d.MailJobPropertyStateNavigation).WithMany(p => p.MailJobs)
            .HasForeignKey(d => d.MailJobPropertyState)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FKStateMailJobPropertyState");
    }
}
