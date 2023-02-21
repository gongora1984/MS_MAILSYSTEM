namespace MAILSYSTEM.INFRASTRUCTURE.Configurations;

internal sealed class CompanyConfiguration : IEntityTypeConfiguration<Company>
{
    public void Configure(EntityTypeBuilder<Company> entity)
    {
        entity.HasKey(e => e.Id).HasName("PKCompany");

        entity.ToTable(TableNames.Company);

        entity.HasIndex(e => e.CompanyBillingState, "FKStateCompanyBillingState");

        entity.HasIndex(e => e.CompanyReturnState, "FKStateCompanyReturnState");

        entity.HasIndex(e => e.CompanyState, "FKStateCompanyState");

        entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

        entity.Property(e => e.CompanyAddress1)
            .HasMaxLength(250)
            .IsUnicode(false);

        entity.Property(e => e.CompanyAddress2)
            .HasMaxLength(200)
            .IsUnicode(false);

        entity.Property(e => e.CompanyBillingAddress1)
            .HasMaxLength(250)
            .IsUnicode(false);

        entity.Property(e => e.CompanyBillingAddress2)
            .HasMaxLength(200)
            .IsUnicode(false);

        entity.Property(e => e.CompanyBillingCity)
            .HasMaxLength(50)
            .IsUnicode(false);

        entity.Property(e => e.CompanyBillingZip)
            .HasMaxLength(15)
            .IsUnicode(false);

        entity.Property(e => e.CompanyCity)
            .HasMaxLength(50)
            .IsUnicode(false);

        entity.Property(e => e.CompanyDefaultFilePathLocation)
            .HasMaxLength(1500)
            .IsUnicode(false);

        entity.Property(e => e.CompanyEmail)
            .HasMaxLength(150)
            .IsUnicode(false);

        entity.Property(e => e.CompanyFax)
            .HasMaxLength(35)
            .IsUnicode(false);

        entity.Property(e => e.CompanyName)
            .HasMaxLength(50)
            .IsUnicode(false);

        entity.Property(e => e.CompanyPassword)
            .HasMaxLength(50)
            .IsUnicode(false);

        entity.Property(e => e.CompanyPhone)
            .HasMaxLength(35)
            .IsUnicode(false);

        entity.Property(e => e.CompanyReturnAddress1)
            .HasMaxLength(250)
            .IsUnicode(false);

        entity.Property(e => e.CompanyReturnAddress2)
            .HasMaxLength(200)
            .IsUnicode(false);

        entity.Property(e => e.CompanyReturnCity)
            .HasMaxLength(50)
            .IsUnicode(false);

        entity.Property(e => e.CompanyReturnEmailAddress)
            .HasMaxLength(150)
            .IsUnicode(false);

        entity.Property(e => e.CompanyReturnName)
            .HasMaxLength(150)
            .IsUnicode(false);

        entity.Property(e => e.CompanyReturnZip)
            .HasMaxLength(15)
            .IsUnicode(false);

        entity.Property(e => e.CompanyUsername)
            .HasMaxLength(50)
            .IsUnicode(false);

        entity.Property(e => e.CompanyZip)
            .HasMaxLength(15)
            .IsUnicode(false)
            .HasColumnName("CompanyZip");

        entity.HasOne(d => d.CompanyBillingStateNavigation).WithMany(p => p.CompanyCompanyBillingStateNavigations)
            .HasForeignKey(d => d.CompanyBillingState)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FKStateCompanyBillingState");

        entity.HasOne(d => d.CompanyReturnStateNavigation).WithMany(p => p.CompanyCompanyReturnStateNavigations)
            .HasForeignKey(d => d.CompanyReturnState)
            .HasConstraintName("FKStateCompanyReturnState");

        entity.HasOne(d => d.CompanyStateNavigation).WithMany(p => p.CompanyCompanyStateNavigations)
            .HasForeignKey(d => d.CompanyState)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FKStateCompanyState");
    }
}
