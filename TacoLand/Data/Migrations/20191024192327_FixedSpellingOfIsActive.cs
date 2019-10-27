using Microsoft.EntityFrameworkCore.Migrations;

namespace TacoLand.Migrations
{
    public partial class FixedSpellingOfIsActive : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "isActive",
                table: "Coupon",
                newName: "IsActive");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IsActive",
                table: "Coupon",
                newName: "isActive");
        }
    }
}
