using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SyndicPfaApp.Migrations
{
    /// <inheritdoc />
    public partial class ChangeAttributes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AscenseurName",
                table: "Ascenseurs",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AscenseurName",
                table: "Ascenseurs");
        }
    }
}
