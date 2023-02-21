﻿// <auto-generated />
using System;
using MAILSYSTEM.INFRASTRUCTURE;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MAILSYSTEM.INFRASTRUCTURE.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230110180527_InitialMigration")]
    partial class InitialMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("MAILSYSTEM.DOMAIN.Entities.Company", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasDefaultValueSql("(newid())");

                    b.Property<string>("CompanyAddress1")
                        .IsRequired()
                        .HasMaxLength(250)
                        .IsUnicode(false)
                        .HasColumnType("varchar(250)");

                    b.Property<string>("CompanyAddress2")
                        .HasMaxLength(200)
                        .IsUnicode(false)
                        .HasColumnType("varchar(200)");

                    b.Property<string>("CompanyBillingAddress1")
                        .IsRequired()
                        .HasMaxLength(250)
                        .IsUnicode(false)
                        .HasColumnType("varchar(250)");

                    b.Property<string>("CompanyBillingAddress2")
                        .HasMaxLength(200)
                        .IsUnicode(false)
                        .HasColumnType("varchar(200)");

                    b.Property<string>("CompanyBillingCity")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<Guid>("CompanyBillingState")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CompanyBillingZip")
                        .IsRequired()
                        .HasMaxLength(15)
                        .IsUnicode(false)
                        .HasColumnType("varchar(15)");

                    b.Property<string>("CompanyCity")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("CompanyDefaultFilePathLocation")
                        .HasMaxLength(1500)
                        .IsUnicode(false)
                        .HasColumnType("varchar(1500)");

                    b.Property<string>("CompanyEmail")
                        .HasMaxLength(150)
                        .IsUnicode(false)
                        .HasColumnType("varchar(150)");

                    b.Property<string>("CompanyFax")
                        .HasMaxLength(35)
                        .IsUnicode(false)
                        .HasColumnType("varchar(35)");

                    b.Property<string>("CompanyName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("CompanyPassword")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("CompanyPhone")
                        .HasMaxLength(35)
                        .IsUnicode(false)
                        .HasColumnType("varchar(35)");

                    b.Property<string>("CompanyReturnAddress1")
                        .HasMaxLength(250)
                        .IsUnicode(false)
                        .HasColumnType("varchar(250)");

                    b.Property<string>("CompanyReturnAddress2")
                        .HasMaxLength(200)
                        .IsUnicode(false)
                        .HasColumnType("varchar(200)");

                    b.Property<string>("CompanyReturnCity")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("CompanyReturnEmailAddress")
                        .HasMaxLength(150)
                        .IsUnicode(false)
                        .HasColumnType("varchar(150)");

                    b.Property<string>("CompanyReturnName")
                        .HasMaxLength(150)
                        .IsUnicode(false)
                        .HasColumnType("varchar(150)");

                    b.Property<Guid?>("CompanyReturnState")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CompanyReturnZip")
                        .HasMaxLength(15)
                        .IsUnicode(false)
                        .HasColumnType("varchar(15)");

                    b.Property<Guid>("CompanyState")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CompanyUsername")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("CompanyZip")
                        .IsRequired()
                        .HasMaxLength(15)
                        .IsUnicode(false)
                        .HasColumnType("varchar(15)")
                        .HasColumnName("Company Zip");

                    b.Property<DateTime>("CreatedOnUtc")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("ModifiedOnUtc")
                        .HasColumnType("datetime2");

                    b.HasKey("Id")
                        .HasName("PKCompany");

                    b.HasIndex(new[] { "CompanyBillingState" }, "FKStateCompanyBillingState");

                    b.HasIndex(new[] { "CompanyReturnState" }, "FKStateCompanyReturnState");

                    b.HasIndex(new[] { "CompanyState" }, "FKStateCompanyState");

                    b.ToTable("Company", (string)null);
                });

            modelBuilder.Entity("MAILSYSTEM.DOMAIN.Entities.CompanyLogin", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasDefaultValueSql("(newid())");

                    b.Property<string>("CompanyAccessToken")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<Guid>("CompanyId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("CompanyLastAccess")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("CreatedOnUtc")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("ModifiedOnUtc")
                        .HasColumnType("datetime2");

                    b.HasKey("Id")
                        .HasName("PKCompanyLogin");

                    b.HasIndex(new[] { "CompanyId" }, "FKCompanyCompanyLogin");

                    b.ToTable("CompanyLogin", (string)null);
                });

            modelBuilder.Entity("MAILSYSTEM.DOMAIN.Entities.ListItem", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasDefaultValueSql("(newid())");

                    b.Property<DateTime>("CreatedOnUtc")
                        .HasColumnType("datetime2");

                    b.Property<string>("ListItemDisplayText")
                        .IsRequired()
                        .HasMaxLength(150)
                        .IsUnicode(false)
                        .HasColumnType("varchar(150)");

                    b.Property<bool?>("ListItemEnable")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValueSql("((1))");

                    b.Property<int>("ListItemOrder")
                        .HasColumnType("int");

                    b.Property<DateTime?>("ModifiedOnUtc")
                        .HasColumnType("datetime2");

                    b.Property<string>("SystemCategory")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("SystemTag")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id")
                        .HasName("PKListItem");

                    b.ToTable("ListItem", (string)null);
                });

            modelBuilder.Entity("MAILSYSTEM.DOMAIN.Entities.MailJob", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasDefaultValueSql("(newid())");

                    b.Property<Guid>("CompanyId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedOnUtc")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("EnvelopTypeId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int?>("MailJobCopies")
                        .HasColumnType("int");

                    b.Property<string>("MailJobCustomData1")
                        .HasMaxLength(150)
                        .IsUnicode(false)
                        .HasColumnType("varchar(150)");

                    b.Property<string>("MailJobCustomData2")
                        .HasMaxLength(150)
                        .IsUnicode(false)
                        .HasColumnType("varchar(150)");

                    b.Property<string>("MailJobCustomData3")
                        .HasMaxLength(150)
                        .IsUnicode(false)
                        .HasColumnType("varchar(150)");

                    b.Property<string>("MailJobDocumentNameOnly")
                        .IsRequired()
                        .HasMaxLength(150)
                        .IsUnicode(false)
                        .HasColumnType("varchar(150)");

                    b.Property<string>("MailJobDocumentPath")
                        .IsRequired()
                        .HasMaxLength(1500)
                        .IsUnicode(false)
                        .HasColumnType("varchar(1500)");

                    b.Property<string>("MailJobEnvelopeCaption1")
                        .HasMaxLength(250)
                        .IsUnicode(false)
                        .HasColumnType("varchar(250)");

                    b.Property<string>("MailJobEnvelopeCaption2")
                        .HasMaxLength(250)
                        .IsUnicode(false)
                        .HasColumnType("varchar(250)");

                    b.Property<string>("MailJobKeyNumber")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("MailJobMailJobPropertyCity")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("MailJobMailJobPropertyZip")
                        .IsRequired()
                        .HasMaxLength(15)
                        .IsUnicode(false)
                        .HasColumnType("varchar(15)");

                    b.Property<int?>("MailJobPages")
                        .HasColumnType("int");

                    b.Property<DateTime?>("MailJobPrintedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("MailJobPropertyAddress1")
                        .IsRequired()
                        .HasMaxLength(250)
                        .IsUnicode(false)
                        .HasColumnType("varchar(250)");

                    b.Property<string>("MailJobPropertyAddress2")
                        .HasMaxLength(200)
                        .IsUnicode(false)
                        .HasColumnType("varchar(200)");

                    b.Property<Guid>("MailJobPropertyState")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("MailJobReceivedOn")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("MailJobSendOutOn")
                        .HasColumnType("datetime2");

                    b.Property<decimal?>("MailJobTotalPostage")
                        .HasColumnType("decimal(16, 2)");

                    b.Property<DateTime?>("MailJobVerifiedOn")
                        .HasColumnType("datetime2");

                    b.Property<bool>("MailJobVoided")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("ModifiedOnUtc")
                        .HasColumnType("datetime2");

                    b.HasKey("Id")
                        .HasName("PKMailJob");

                    b.HasIndex(new[] { "CompanyId" }, "FKCompanyMailJob");

                    b.HasIndex(new[] { "EnvelopTypeId" }, "FKMailJobListItemEnvelopType");

                    b.HasIndex(new[] { "MailJobPropertyState" }, "FKStateMailJobPropertyState");

                    b.ToTable("MailJob", (string)null);
                });

            modelBuilder.Entity("MAILSYSTEM.DOMAIN.Entities.MailJobDetail", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasDefaultValueSql("(newid())");

                    b.Property<DateTime>("CreatedOnUtc")
                        .HasColumnType("datetime2");

                    b.Property<string>("MailJobDetailChangedRecipientAddress1")
                        .HasMaxLength(250)
                        .IsUnicode(false)
                        .HasColumnType("varchar(250)");

                    b.Property<string>("MailJobDetailChangedRecipientAddress2")
                        .HasMaxLength(200)
                        .IsUnicode(false)
                        .HasColumnType("varchar(200)");

                    b.Property<string>("MailJobDetailChangedRecipientCity")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("MailJobDetailChangedRecipientName")
                        .HasMaxLength(350)
                        .IsUnicode(false)
                        .HasColumnType("varchar(350)");

                    b.Property<Guid?>("MailJobDetailChangedRecipientState")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("MailJobDetailChangedRecipientZip")
                        .HasMaxLength(15)
                        .IsUnicode(false)
                        .HasColumnType("varchar(15)");

                    b.Property<DateTime?>("MailJobDetailCorrectedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("MailJobDetailNotSentNote")
                        .HasMaxLength(1500)
                        .IsUnicode(false)
                        .HasColumnType("varchar(1500)");

                    b.Property<decimal?>("MailJobDetailPostageAmount")
                        .HasColumnType("decimal(16, 3)");

                    b.Property<DateTime?>("MailJobDetailPrintedOn")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("MailJobDetailReceivedOn")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("(getdate())");

                    b.Property<DateTime?>("MailJobDetailReturnedOn")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("MailJobDetailSentOutOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("MailJobDetailTrackingNumber")
                        .HasMaxLength(150)
                        .IsUnicode(false)
                        .HasColumnType("varchar(150)");

                    b.Property<DateTime?>("MailJobDetailVerifiedOn")
                        .HasColumnType("datetime2");

                    b.Property<bool>("MailJobDetailVoided")
                        .HasColumnType("bit");

                    b.Property<bool>("MailJobDetailWasCorrected")
                        .HasColumnType("bit");

                    b.Property<bool>("MailJobDetailWasReturned")
                        .HasColumnType("bit");

                    b.Property<Guid>("MailJobId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("ModifiedOnUtc")
                        .HasColumnType("datetime2");

                    b.Property<string>("RecipientAddress1")
                        .IsRequired()
                        .HasMaxLength(250)
                        .IsUnicode(false)
                        .HasColumnType("varchar(250)");

                    b.Property<string>("RecipientAddress2")
                        .HasMaxLength(200)
                        .IsUnicode(false)
                        .HasColumnType("varchar(200)");

                    b.Property<string>("RecipientCity")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("RecipientName")
                        .IsRequired()
                        .HasMaxLength(350)
                        .IsUnicode(false)
                        .HasColumnType("varchar(350)");

                    b.Property<Guid>("RecipientState")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("RecipientZip")
                        .IsRequired()
                        .HasMaxLength(15)
                        .IsUnicode(false)
                        .HasColumnType("varchar(15)");

                    b.HasKey("Id")
                        .HasName("PKMailJobDetail");

                    b.HasIndex(new[] { "MailJobId" }, "FKMailJobMailJobDetail");

                    b.HasIndex(new[] { "MailJobDetailChangedRecipientState" }, "FKStateMailJobDetailChangedRecipientState");

                    b.HasIndex(new[] { "RecipientState" }, "FKStateMailJobDetailRecipientState");

                    b.ToTable("MailJobDetail", (string)null);
                });

            modelBuilder.Entity("MAILSYSTEM.DOMAIN.Entities.State", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasDefaultValueSql("(newid())");

                    b.Property<DateTime>("CreatedOnUtc")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("ModifiedOnUtc")
                        .HasColumnType("datetime2");

                    b.Property<string>("StateAbbreviation")
                        .IsRequired()
                        .HasMaxLength(2)
                        .IsUnicode(false)
                        .HasColumnType("varchar(2)");

                    b.Property<string>("StateDescription")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id")
                        .HasName("PKState");

                    b.ToTable("State", (string)null);
                });

            modelBuilder.Entity("MAILSYSTEM.DOMAIN.Entities.Company", b =>
                {
                    b.HasOne("MAILSYSTEM.DOMAIN.Entities.State", "CompanyBillingStateNavigation")
                        .WithMany("CompanyCompanyBillingStateNavigations")
                        .HasForeignKey("CompanyBillingState")
                        .IsRequired()
                        .HasConstraintName("FKStateCompanyBillingState");

                    b.HasOne("MAILSYSTEM.DOMAIN.Entities.State", "CompanyReturnStateNavigation")
                        .WithMany("CompanyCompanyReturnStateNavigations")
                        .HasForeignKey("CompanyReturnState")
                        .HasConstraintName("FKStateCompanyReturnState");

                    b.HasOne("MAILSYSTEM.DOMAIN.Entities.State", "CompanyStateNavigation")
                        .WithMany("CompanyCompanyStateNavigations")
                        .HasForeignKey("CompanyState")
                        .IsRequired()
                        .HasConstraintName("FKStateCompanyState");

                    b.Navigation("CompanyBillingStateNavigation");

                    b.Navigation("CompanyReturnStateNavigation");

                    b.Navigation("CompanyStateNavigation");
                });

            modelBuilder.Entity("MAILSYSTEM.DOMAIN.Entities.CompanyLogin", b =>
                {
                    b.HasOne("MAILSYSTEM.DOMAIN.Entities.Company", "Company")
                        .WithMany("CompanyLogins")
                        .HasForeignKey("CompanyId")
                        .IsRequired()
                        .HasConstraintName("FKCompanyCompanyLogin");

                    b.Navigation("Company");
                });

            modelBuilder.Entity("MAILSYSTEM.DOMAIN.Entities.MailJob", b =>
                {
                    b.HasOne("MAILSYSTEM.DOMAIN.Entities.Company", "Company")
                        .WithMany("MailJobs")
                        .HasForeignKey("CompanyId")
                        .IsRequired()
                        .HasConstraintName("FKCompanyMailJob");

                    b.HasOne("MAILSYSTEM.DOMAIN.Entities.ListItem", "EnvelopType")
                        .WithMany("MailJobs")
                        .HasForeignKey("EnvelopTypeId")
                        .IsRequired()
                        .HasConstraintName("FKMailJobListItemEnvelopType");

                    b.HasOne("MAILSYSTEM.DOMAIN.Entities.State", "MailJobPropertyStateNavigation")
                        .WithMany("MailJobs")
                        .HasForeignKey("MailJobPropertyState")
                        .IsRequired()
                        .HasConstraintName("FKStateMailJobPropertyState");

                    b.Navigation("Company");

                    b.Navigation("EnvelopType");

                    b.Navigation("MailJobPropertyStateNavigation");
                });

            modelBuilder.Entity("MAILSYSTEM.DOMAIN.Entities.MailJobDetail", b =>
                {
                    b.HasOne("MAILSYSTEM.DOMAIN.Entities.State", "MailJobDetailChangedRecipientStateNavigation")
                        .WithMany("MailJobDetailMailJobDetailChangedRecipientStateNavigations")
                        .HasForeignKey("MailJobDetailChangedRecipientState")
                        .HasConstraintName("FKStateMailJobDetailChangedRecipientState");

                    b.HasOne("MAILSYSTEM.DOMAIN.Entities.MailJob", "MailJob")
                        .WithMany("MailJobDetails")
                        .HasForeignKey("MailJobId")
                        .IsRequired()
                        .HasConstraintName("FKMailJobMailJobDetail");

                    b.HasOne("MAILSYSTEM.DOMAIN.Entities.State", "RecipientStateNavigation")
                        .WithMany("MailJobDetailRecipientStateNavigations")
                        .HasForeignKey("RecipientState")
                        .IsRequired()
                        .HasConstraintName("FKStateMailJobDetailRecipientState");

                    b.Navigation("MailJob");

                    b.Navigation("MailJobDetailChangedRecipientStateNavigation");

                    b.Navigation("RecipientStateNavigation");
                });

            modelBuilder.Entity("MAILSYSTEM.DOMAIN.Entities.Company", b =>
                {
                    b.Navigation("CompanyLogins");

                    b.Navigation("MailJobs");
                });

            modelBuilder.Entity("MAILSYSTEM.DOMAIN.Entities.ListItem", b =>
                {
                    b.Navigation("MailJobs");
                });

            modelBuilder.Entity("MAILSYSTEM.DOMAIN.Entities.MailJob", b =>
                {
                    b.Navigation("MailJobDetails");
                });

            modelBuilder.Entity("MAILSYSTEM.DOMAIN.Entities.State", b =>
                {
                    b.Navigation("CompanyCompanyBillingStateNavigations");

                    b.Navigation("CompanyCompanyReturnStateNavigations");

                    b.Navigation("CompanyCompanyStateNavigations");

                    b.Navigation("MailJobDetailMailJobDetailChangedRecipientStateNavigations");

                    b.Navigation("MailJobDetailRecipientStateNavigations");

                    b.Navigation("MailJobs");
                });
#pragma warning restore 612, 618
        }
    }
}
