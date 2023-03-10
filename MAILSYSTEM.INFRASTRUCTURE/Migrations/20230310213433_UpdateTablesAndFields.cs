using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MAILSYSTEM.INFRASTRUCTURE.Migrations
{
    /// <inheritdoc />
    public partial class UpdateTablesAndFields : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "MailJobDetailWasReturned",
                table: "MailJobDetail",
                newName: "WasReturned");

            migrationBuilder.RenameColumn(
                name: "MailJobDetailWasCorrected",
                table: "MailJobDetail",
                newName: "WasCorrected");

            migrationBuilder.RenameColumn(
                name: "MailJobDetailVoided",
                table: "MailJobDetail",
                newName: "Voided");

            migrationBuilder.RenameColumn(
                name: "MailJobDetailVerifiedOn",
                table: "MailJobDetail",
                newName: "VerifiedOn");

            migrationBuilder.RenameColumn(
                name: "MailJobDetailTrackingNumber",
                table: "MailJobDetail",
                newName: "TrackingNumber");

            migrationBuilder.RenameColumn(
                name: "MailJobDetailSentOutOn",
                table: "MailJobDetail",
                newName: "SentOutOn");

            migrationBuilder.RenameColumn(
                name: "MailJobDetailReturnedOn",
                table: "MailJobDetail",
                newName: "ReturnedOn");

            migrationBuilder.RenameColumn(
                name: "MailJobDetailReceivedOn",
                table: "MailJobDetail",
                newName: "ReceivedOn");

            migrationBuilder.RenameColumn(
                name: "MailJobDetailPrintedOn",
                table: "MailJobDetail",
                newName: "PrintedOn");

            migrationBuilder.RenameColumn(
                name: "MailJobDetailPostageAmount",
                table: "MailJobDetail",
                newName: "PostageAmount");

            migrationBuilder.RenameColumn(
                name: "MailJobDetailNotSentNote",
                table: "MailJobDetail",
                newName: "NotSentNote");

            migrationBuilder.RenameColumn(
                name: "MailJobDetailCorrectedOn",
                table: "MailJobDetail",
                newName: "CorrectedOn");

            migrationBuilder.RenameColumn(
                name: "MailJobDetailChangedRecipientZip",
                table: "MailJobDetail",
                newName: "ChangedRecipientZip");

            migrationBuilder.RenameColumn(
                name: "MailJobDetailChangedRecipientState",
                table: "MailJobDetail",
                newName: "ChangedRecipientState");

            migrationBuilder.RenameColumn(
                name: "MailJobDetailChangedRecipientName",
                table: "MailJobDetail",
                newName: "ChangedRecipientName");

            migrationBuilder.RenameColumn(
                name: "MailJobDetailChangedRecipientCity",
                table: "MailJobDetail",
                newName: "ChangedRecipientCity");

            migrationBuilder.RenameColumn(
                name: "MailJobDetailChangedRecipientAddress2",
                table: "MailJobDetail",
                newName: "ChangedRecipientAddress2");

            migrationBuilder.RenameColumn(
                name: "MailJobDetailChangedRecipientAddress1",
                table: "MailJobDetail",
                newName: "ChangedRecipientAddress1");

            migrationBuilder.RenameColumn(
                name: "MailJobVoided",
                table: "MailJob",
                newName: "Voided");

            migrationBuilder.RenameColumn(
                name: "MailJobVerifiedOn",
                table: "MailJob",
                newName: "VerifiedOn");

            migrationBuilder.RenameColumn(
                name: "MailJobTotalPostage",
                table: "MailJob",
                newName: "TotalPostage");

            migrationBuilder.RenameColumn(
                name: "MailJobSendOutOn",
                table: "MailJob",
                newName: "SendOutOn");

            migrationBuilder.RenameColumn(
                name: "MailJobReceivedOn",
                table: "MailJob",
                newName: "ReceivedOn");

            migrationBuilder.RenameColumn(
                name: "MailJobPropertyState",
                table: "MailJob",
                newName: "PropertyState");

            migrationBuilder.RenameColumn(
                name: "MailJobPropertyAddress2",
                table: "MailJob",
                newName: "PropertyAddress2");

            migrationBuilder.RenameColumn(
                name: "MailJobPropertyAddress1",
                table: "MailJob",
                newName: "PropertyAddress1");

            migrationBuilder.RenameColumn(
                name: "MailJobPrintedOn",
                table: "MailJob",
                newName: "PrintedOn");

            migrationBuilder.RenameColumn(
                name: "MailJobPages",
                table: "MailJob",
                newName: "Pages");

            migrationBuilder.RenameColumn(
                name: "MailJobMailJobPropertyZip",
                table: "MailJob",
                newName: "PropertyZip");

            migrationBuilder.RenameColumn(
                name: "MailJobMailJobPropertyCity",
                table: "MailJob",
                newName: "PropertyCity");

            migrationBuilder.RenameColumn(
                name: "MailJobKeyNumber",
                table: "MailJob",
                newName: "KeyNumber");

            migrationBuilder.RenameColumn(
                name: "MailJobEnvelopeCaption2",
                table: "MailJob",
                newName: "EnvelopeCaption2");

            migrationBuilder.RenameColumn(
                name: "MailJobEnvelopeCaption1",
                table: "MailJob",
                newName: "EnvelopeCaption1");

            migrationBuilder.RenameColumn(
                name: "MailJobDocumentPath",
                table: "MailJob",
                newName: "DocumentPath");

            migrationBuilder.RenameColumn(
                name: "MailJobDocumentNameOnly",
                table: "MailJob",
                newName: "DocumentNameOnly");

            migrationBuilder.RenameColumn(
                name: "MailJobCustomData3",
                table: "MailJob",
                newName: "CustomData3");

            migrationBuilder.RenameColumn(
                name: "MailJobCustomData2",
                table: "MailJob",
                newName: "CustomData2");

            migrationBuilder.RenameColumn(
                name: "MailJobCustomData1",
                table: "MailJob",
                newName: "CustomData1");

            migrationBuilder.RenameColumn(
                name: "MailJobCopies",
                table: "MailJob",
                newName: "Copies");

            migrationBuilder.RenameIndex(
                name: "FKStateMailJobPropertyState",
                table: "MailJob",
                newName: "FKStatePropertyState");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "WasReturned",
                table: "MailJobDetail",
                newName: "MailJobDetailWasReturned");

            migrationBuilder.RenameColumn(
                name: "WasCorrected",
                table: "MailJobDetail",
                newName: "MailJobDetailWasCorrected");

            migrationBuilder.RenameColumn(
                name: "Voided",
                table: "MailJobDetail",
                newName: "MailJobDetailVoided");

            migrationBuilder.RenameColumn(
                name: "VerifiedOn",
                table: "MailJobDetail",
                newName: "MailJobDetailVerifiedOn");

            migrationBuilder.RenameColumn(
                name: "TrackingNumber",
                table: "MailJobDetail",
                newName: "MailJobDetailTrackingNumber");

            migrationBuilder.RenameColumn(
                name: "SentOutOn",
                table: "MailJobDetail",
                newName: "MailJobDetailSentOutOn");

            migrationBuilder.RenameColumn(
                name: "ReturnedOn",
                table: "MailJobDetail",
                newName: "MailJobDetailReturnedOn");

            migrationBuilder.RenameColumn(
                name: "ReceivedOn",
                table: "MailJobDetail",
                newName: "MailJobDetailReceivedOn");

            migrationBuilder.RenameColumn(
                name: "PrintedOn",
                table: "MailJobDetail",
                newName: "MailJobDetailPrintedOn");

            migrationBuilder.RenameColumn(
                name: "PostageAmount",
                table: "MailJobDetail",
                newName: "MailJobDetailPostageAmount");

            migrationBuilder.RenameColumn(
                name: "NotSentNote",
                table: "MailJobDetail",
                newName: "MailJobDetailNotSentNote");

            migrationBuilder.RenameColumn(
                name: "CorrectedOn",
                table: "MailJobDetail",
                newName: "MailJobDetailCorrectedOn");

            migrationBuilder.RenameColumn(
                name: "ChangedRecipientZip",
                table: "MailJobDetail",
                newName: "MailJobDetailChangedRecipientZip");

            migrationBuilder.RenameColumn(
                name: "ChangedRecipientState",
                table: "MailJobDetail",
                newName: "MailJobDetailChangedRecipientState");

            migrationBuilder.RenameColumn(
                name: "ChangedRecipientName",
                table: "MailJobDetail",
                newName: "MailJobDetailChangedRecipientName");

            migrationBuilder.RenameColumn(
                name: "ChangedRecipientCity",
                table: "MailJobDetail",
                newName: "MailJobDetailChangedRecipientCity");

            migrationBuilder.RenameColumn(
                name: "ChangedRecipientAddress2",
                table: "MailJobDetail",
                newName: "MailJobDetailChangedRecipientAddress2");

            migrationBuilder.RenameColumn(
                name: "ChangedRecipientAddress1",
                table: "MailJobDetail",
                newName: "MailJobDetailChangedRecipientAddress1");

            migrationBuilder.RenameColumn(
                name: "Voided",
                table: "MailJob",
                newName: "MailJobVoided");

            migrationBuilder.RenameColumn(
                name: "VerifiedOn",
                table: "MailJob",
                newName: "MailJobVerifiedOn");

            migrationBuilder.RenameColumn(
                name: "TotalPostage",
                table: "MailJob",
                newName: "MailJobTotalPostage");

            migrationBuilder.RenameColumn(
                name: "SendOutOn",
                table: "MailJob",
                newName: "MailJobSendOutOn");

            migrationBuilder.RenameColumn(
                name: "ReceivedOn",
                table: "MailJob",
                newName: "MailJobReceivedOn");

            migrationBuilder.RenameColumn(
                name: "PropertyZip",
                table: "MailJob",
                newName: "MailJobMailJobPropertyZip");

            migrationBuilder.RenameColumn(
                name: "PropertyState",
                table: "MailJob",
                newName: "MailJobPropertyState");

            migrationBuilder.RenameColumn(
                name: "PropertyCity",
                table: "MailJob",
                newName: "MailJobMailJobPropertyCity");

            migrationBuilder.RenameColumn(
                name: "PropertyAddress2",
                table: "MailJob",
                newName: "MailJobPropertyAddress2");

            migrationBuilder.RenameColumn(
                name: "PropertyAddress1",
                table: "MailJob",
                newName: "MailJobPropertyAddress1");

            migrationBuilder.RenameColumn(
                name: "PrintedOn",
                table: "MailJob",
                newName: "MailJobPrintedOn");

            migrationBuilder.RenameColumn(
                name: "Pages",
                table: "MailJob",
                newName: "MailJobPages");

            migrationBuilder.RenameColumn(
                name: "KeyNumber",
                table: "MailJob",
                newName: "MailJobKeyNumber");

            migrationBuilder.RenameColumn(
                name: "EnvelopeCaption2",
                table: "MailJob",
                newName: "MailJobEnvelopeCaption2");

            migrationBuilder.RenameColumn(
                name: "EnvelopeCaption1",
                table: "MailJob",
                newName: "MailJobEnvelopeCaption1");

            migrationBuilder.RenameColumn(
                name: "DocumentPath",
                table: "MailJob",
                newName: "MailJobDocumentPath");

            migrationBuilder.RenameColumn(
                name: "DocumentNameOnly",
                table: "MailJob",
                newName: "MailJobDocumentNameOnly");

            migrationBuilder.RenameColumn(
                name: "CustomData3",
                table: "MailJob",
                newName: "MailJobCustomData3");

            migrationBuilder.RenameColumn(
                name: "CustomData2",
                table: "MailJob",
                newName: "MailJobCustomData2");

            migrationBuilder.RenameColumn(
                name: "CustomData1",
                table: "MailJob",
                newName: "MailJobCustomData1");

            migrationBuilder.RenameColumn(
                name: "Copies",
                table: "MailJob",
                newName: "MailJobCopies");

            migrationBuilder.RenameIndex(
                name: "FKStatePropertyState",
                table: "MailJob",
                newName: "FKStateMailJobPropertyState");
        }
    }
}
