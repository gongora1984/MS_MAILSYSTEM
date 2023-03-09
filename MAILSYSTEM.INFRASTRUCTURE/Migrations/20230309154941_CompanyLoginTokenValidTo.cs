using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MAILSYSTEM.INFRASTRUCTURE.Migrations
{
    /// <inheritdoc />
    public partial class CompanyLoginTokenValidTo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CompanyAccessTokenValidTo",
                table: "CompanyLogin",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CompanyAccessTokenValidTo",
                table: "CompanyLogin");
        }
    }
}
