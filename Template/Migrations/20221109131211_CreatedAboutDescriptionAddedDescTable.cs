using Microsoft.EntityFrameworkCore.Migrations;

namespace Template.Migrations
{
    public partial class CreatedAboutDescriptionAddedDescTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "AboutDescriptions");

            migrationBuilder.AddColumn<string>(
                name: "Description1",
                table: "AboutDescriptions",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Description2",
                table: "AboutDescriptions",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Description3",
                table: "AboutDescriptions",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Description4",
                table: "AboutDescriptions",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Description5",
                table: "AboutDescriptions",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description1",
                table: "AboutDescriptions");

            migrationBuilder.DropColumn(
                name: "Description2",
                table: "AboutDescriptions");

            migrationBuilder.DropColumn(
                name: "Description3",
                table: "AboutDescriptions");

            migrationBuilder.DropColumn(
                name: "Description4",
                table: "AboutDescriptions");

            migrationBuilder.DropColumn(
                name: "Description5",
                table: "AboutDescriptions");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "AboutDescriptions",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
