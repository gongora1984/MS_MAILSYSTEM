using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MAILSYSTEM.INFRASTRUCTURE.Migrations
{
    /// <inheritdoc />
    public partial class CompanyZipUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Company Zip",
                table: "Company",
                newName: "CompanyZip");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CompanyZip",
                table: "Company",
                newName: "Company Zip");
        }
    }
}
