using Microsoft.EntityFrameworkCore.Migrations;

namespace GT_regisztracio.Data.Migrations
{
    public partial class eredmenyek_table_added : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "EredmenyUID",
                table: "Pontozas",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Eredmenyek",
                columns: table => new
                {
                    UID = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Eredmenyek", x => x.UID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Pontozas_EredmenyUID",
                table: "Pontozas",
                column: "EredmenyUID");

            migrationBuilder.AddForeignKey(
                name: "FK_Pontozas_Eredmenyek_EredmenyUID",
                table: "Pontozas",
                column: "EredmenyUID",
                principalTable: "Eredmenyek",
                principalColumn: "UID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pontozas_Eredmenyek_EredmenyUID",
                table: "Pontozas");

            migrationBuilder.DropTable(
                name: "Eredmenyek");

            migrationBuilder.DropIndex(
                name: "IX_Pontozas_EredmenyUID",
                table: "Pontozas");

            migrationBuilder.DropColumn(
                name: "EredmenyUID",
                table: "Pontozas");
        }
    }
}
