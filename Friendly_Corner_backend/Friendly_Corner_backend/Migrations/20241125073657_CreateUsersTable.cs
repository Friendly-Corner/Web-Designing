using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Friendly_Corner_backend.Migrations
{
    /// <inheritdoc />
    public partial class CreateUsersTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
        name: "Name",
        table: "Users",
        type: "nvarchar(max)",
        nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PictureUrl",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "WebUrl",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(name: "Name", table: "Users");
            migrationBuilder.DropColumn(name: "PictureUrl", table: "Users");
            migrationBuilder.DropColumn(name: "WebUrl", table: "Users");
            migrationBuilder.DropColumn(name: "Description", table: "Users");

        }
    }
}
