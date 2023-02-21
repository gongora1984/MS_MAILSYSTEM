using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MAILSYSTEM.INFRASTRUCTURE.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ListItem",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "(newid())"),
                    SystemCategory = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    SystemTag = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    ListItemDisplayText = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: false),
                    ListItemOrder = table.Column<int>(type: "int", nullable: false),
                    ListItemEnable = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "((1))"),
                    CreatedOnUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedOnUtc = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PKListItem", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "State",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "(newid())"),
                    StateAbbreviation = table.Column<string>(type: "varchar(2)", unicode: false, maxLength: 2, nullable: false),
                    StateDescription = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    CreatedOnUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedOnUtc = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PKState", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Company",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "(newid())"),
                    CompanyName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    CompanyUsername = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    CompanyPassword = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    CompanyAddress1 = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: false),
                    CompanyAddress2 = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    CompanyCity = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    CompanyState = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CompanyZip = table.Column<string>(name: "Company Zip", type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    CompanyPhone = table.Column<string>(type: "varchar(35)", unicode: false, maxLength: 35, nullable: true),
                    CompanyFax = table.Column<string>(type: "varchar(35)", unicode: false, maxLength: 35, nullable: true),
                    CompanyEmail = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    CompanyBillingAddress1 = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: false),
                    CompanyBillingAddress2 = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    CompanyBillingCity = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    CompanyBillingState = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CompanyBillingZip = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    CompanyReturnName = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    CompanyReturnAddress1 = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    CompanyReturnAddress2 = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    CompanyReturnCity = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    CompanyReturnState = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CompanyReturnZip = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    CompanyReturnEmailAddress = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    CompanyDefaultFilePathLocation = table.Column<string>(type: "varchar(1500)", unicode: false, maxLength: 1500, nullable: true),
                    CreatedOnUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedOnUtc = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PKCompany", x => x.Id);
                    table.ForeignKey(
                        name: "FKStateCompanyBillingState",
                        column: x => x.CompanyBillingState,
                        principalTable: "State",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FKStateCompanyReturnState",
                        column: x => x.CompanyReturnState,
                        principalTable: "State",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FKStateCompanyState",
                        column: x => x.CompanyState,
                        principalTable: "State",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "CompanyLogin",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "(newid())"),
                    CompanyId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CompanyAccessToken = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    CompanyLastAccess = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedOnUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedOnUtc = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PKCompanyLogin", x => x.Id);
                    table.ForeignKey(
                        name: "FKCompanyCompanyLogin",
                        column: x => x.CompanyId,
                        principalTable: "Company",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "MailJob",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "(newid())"),
                    EnvelopTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CompanyId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MailJobKeyNumber = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    MailJobPages = table.Column<int>(type: "int", nullable: true),
                    MailJobCopies = table.Column<int>(type: "int", nullable: true),
                    MailJobTotalPostage = table.Column<decimal>(type: "decimal(16,2)", nullable: true),
                    MailJobReceivedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MailJobVerifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    MailJobPrintedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    MailJobSendOutOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    MailJobDocumentNameOnly = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: false),
                    MailJobDocumentPath = table.Column<string>(type: "varchar(1500)", unicode: false, maxLength: 1500, nullable: false),
                    MailJobPropertyAddress1 = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: false),
                    MailJobPropertyAddress2 = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    MailJobMailJobPropertyCity = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    MailJobPropertyState = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MailJobMailJobPropertyZip = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    MailJobVoided = table.Column<bool>(type: "bit", nullable: false),
                    MailJobCustomData1 = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    MailJobCustomData2 = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    MailJobCustomData3 = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    MailJobEnvelopeCaption1 = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    MailJobEnvelopeCaption2 = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    CreatedOnUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedOnUtc = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PKMailJob", x => x.Id);
                    table.ForeignKey(
                        name: "FKCompanyMailJob",
                        column: x => x.CompanyId,
                        principalTable: "Company",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FKMailJobListItemEnvelopType",
                        column: x => x.EnvelopTypeId,
                        principalTable: "ListItem",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FKStateMailJobPropertyState",
                        column: x => x.MailJobPropertyState,
                        principalTable: "State",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "MailJobDetail",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "(newid())"),
                    MailJobId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RecipientName = table.Column<string>(type: "varchar(350)", unicode: false, maxLength: 350, nullable: false),
                    RecipientAddress1 = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: false),
                    RecipientAddress2 = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    RecipientCity = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    RecipientState = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RecipientZip = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    MailJobDetailReceivedOn = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "(getdate())"),
                    MailJobDetailVerifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    MailJobDetailPrintedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    MailJobDetailSentOutOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    MailJobDetailPostageAmount = table.Column<decimal>(type: "decimal(16,3)", nullable: true),
                    MailJobDetailTrackingNumber = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    MailJobDetailNotSentNote = table.Column<string>(type: "varchar(1500)", unicode: false, maxLength: 1500, nullable: true),
                    MailJobDetailVoided = table.Column<bool>(type: "bit", nullable: false),
                    MailJobDetailWasCorrected = table.Column<bool>(type: "bit", nullable: false),
                    MailJobDetailCorrectedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    MailJobDetailChangedRecipientName = table.Column<string>(type: "varchar(350)", unicode: false, maxLength: 350, nullable: true),
                    MailJobDetailChangedRecipientAddress1 = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    MailJobDetailChangedRecipientAddress2 = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    MailJobDetailChangedRecipientCity = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    MailJobDetailChangedRecipientState = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    MailJobDetailChangedRecipientZip = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    MailJobDetailWasReturned = table.Column<bool>(type: "bit", nullable: false),
                    MailJobDetailReturnedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedOnUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedOnUtc = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PKMailJobDetail", x => x.Id);
                    table.ForeignKey(
                        name: "FKMailJobMailJobDetail",
                        column: x => x.MailJobId,
                        principalTable: "MailJob",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FKStateMailJobDetailChangedRecipientState",
                        column: x => x.MailJobDetailChangedRecipientState,
                        principalTable: "State",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FKStateMailJobDetailRecipientState",
                        column: x => x.RecipientState,
                        principalTable: "State",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "FKStateCompanyBillingState",
                table: "Company",
                column: "CompanyBillingState");

            migrationBuilder.CreateIndex(
                name: "FKStateCompanyReturnState",
                table: "Company",
                column: "CompanyReturnState");

            migrationBuilder.CreateIndex(
                name: "FKStateCompanyState",
                table: "Company",
                column: "CompanyState");

            migrationBuilder.CreateIndex(
                name: "FKCompanyCompanyLogin",
                table: "CompanyLogin",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "FKCompanyMailJob",
                table: "MailJob",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "FKMailJobListItemEnvelopType",
                table: "MailJob",
                column: "EnvelopTypeId");

            migrationBuilder.CreateIndex(
                name: "FKStateMailJobPropertyState",
                table: "MailJob",
                column: "MailJobPropertyState");

            migrationBuilder.CreateIndex(
                name: "FKMailJobMailJobDetail",
                table: "MailJobDetail",
                column: "MailJobId");

            migrationBuilder.CreateIndex(
                name: "FKStateMailJobDetailChangedRecipientState",
                table: "MailJobDetail",
                column: "MailJobDetailChangedRecipientState");

            migrationBuilder.CreateIndex(
                name: "FKStateMailJobDetailRecipientState",
                table: "MailJobDetail",
                column: "RecipientState");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CompanyLogin");

            migrationBuilder.DropTable(
                name: "MailJobDetail");

            migrationBuilder.DropTable(
                name: "MailJob");

            migrationBuilder.DropTable(
                name: "Company");

            migrationBuilder.DropTable(
                name: "ListItem");

            migrationBuilder.DropTable(
                name: "State");
        }
    }
}
