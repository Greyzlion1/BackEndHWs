using Microsoft.EntityFrameworkCore.Migrations;

namespace HW1.Migrations
{
    public partial class UpdatePricingTableAddedAdvancedFeature : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Advanced",
                table: "Pricings",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Advanced",
                table: "Pricings");
        }
    }
}
