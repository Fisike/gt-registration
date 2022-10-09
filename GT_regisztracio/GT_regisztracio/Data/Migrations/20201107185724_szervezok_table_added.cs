using Microsoft.EntityFrameworkCore.Migrations;

namespace GT_regisztracio.Data.Migrations
{
    public partial class szervezok_table_added : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Szervezok",
                columns: table => new
                {
                    UID = table.Column<string>(nullable: false),
                    Vezeteknev = table.Column<string>(maxLength: 100, nullable: true),
                    Keresztnev = table.Column<string>(maxLength: 100, nullable: true),
                    Neptun = table.Column<string>(maxLength: 6, nullable: true),
                    Telefon = table.Column<string>(maxLength: 20, nullable: true),
                    Bemutatkozas = table.Column<string>(maxLength: 1500, nullable: true),
                    Pozicio = table.Column<int>(nullable: false),
                    Megjegyzes = table.Column<string>(maxLength: 300, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Szervezok", x => x.UID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Szervezok");
        }
    }
}
