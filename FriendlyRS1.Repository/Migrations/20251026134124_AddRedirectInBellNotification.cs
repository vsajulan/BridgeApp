using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FriendlyRS1.Repository.Migrations
{
    /// <inheritdoc />
    public partial class AddRedirectInBellNotification : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "RedirectAction",
                table: "BellNotification",
                type: "varchar(50)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RedirectController",
                table: "BellNotification",
                type: "varchar(50)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RedirectParam",
                table: "BellNotification",
                type: "varchar(500)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RedirectAction",
                table: "BellNotification");

            migrationBuilder.DropColumn(
                name: "RedirectController",
                table: "BellNotification");

            migrationBuilder.DropColumn(
                name: "RedirectParam",
                table: "BellNotification");
        }
    }
}
