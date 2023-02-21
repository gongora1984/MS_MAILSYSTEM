namespace MAILSYSTEM.INFRASTRUCTURE.Configurations;

internal sealed class CompanyLoginConfiguration : IEntityTypeConfiguration<CompanyLogin>
{
    public void Configure(EntityTypeBuilder<CompanyLogin> entity)
    {
        entity.HasKey(e => e.Id).HasName("PKCompanyLogin");

        entity.ToTable(TableNames.CompanyLogin);

        entity.HasIndex(e => e.CompanyId, "FKCompanyCompanyLogin");

        entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

        entity.Property(e => e.CompanyAccessToken)
            .HasMaxLength(50)
            .IsUnicode(false);

        entity.HasOne(d => d.Company).WithMany(p => p.CompanyLogins)
            .HasForeignKey(d => d.CompanyId)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FKCompanyCompanyLogin");
    }
}
