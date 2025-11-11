using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FriendlyRS1.Repository.Migrations
{
    /// <inheritdoc />
    public partial class AddColumnVisibilityPost : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Visibility",
                table: "Post",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Visibility",
                table: "Post");
        }
    }
}
