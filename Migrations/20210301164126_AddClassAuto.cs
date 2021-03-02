using Microsoft.EntityFrameworkCore.Migrations;

namespace Carwash.Migrations
{
    public partial class AddClassAuto : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ClassAuto",
                table: "Products",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ClassAuto",
                table: "Products");
        }
    }
}
