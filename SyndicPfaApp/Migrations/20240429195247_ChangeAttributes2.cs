using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SyndicPfaApp.Migrations
{
    /// <inheritdoc />
    public partial class ChangeAttributes2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DateEntretien",
                table: "Interventions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateEntretien",
                table: "Interventions");
        }
    }
}
