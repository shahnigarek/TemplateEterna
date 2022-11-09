using Microsoft.EntityFrameworkCore.Migrations;

namespace Template.Migrations
{
    public partial class CreatedPricingTable2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsAdvanced",
                table: "Pricings");

            migrationBuilder.DropColumn(
                name: "IsFeatured",
                table: "Pricings");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsAdvanced",
                table: "Pricings",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsFeatured",
                table: "Pricings",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }
    }
}
