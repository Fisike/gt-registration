using Microsoft.EntityFrameworkCore.Migrations;

namespace GT_regisztracio.Data.Migrations
{
    public partial class email_added : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Szervezok",
                maxLength: 100,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Email",
                table: "Szervezok");
        }
    }
}
