using Microsoft.EntityFrameworkCore.Migrations;

namespace GT_regisztracio.Data.Migrations
{
    public partial class alap : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pont_Pontozas_PontozasUID",
                table: "Pont");

            migrationBuilder.DropTable(
                name: "Pontozas");

            migrationBuilder.DropIndex(
                name: "IX_Pont_PontozasUID",
                table: "Pont");

            migrationBuilder.DropColumn(
                name: "PontozasUID",
                table: "Pont");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "AspNetUsers");

            migrationBuilder.AddColumn<string>(
                name: "PontozoNev",
                table: "Pont",
                maxLength: 100,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PontozoNev",
                table: "Pont");

            migrationBuilder.AddColumn<string>(
                name: "PontozasUID",
                table: "Pont",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "Pontozas",
                columns: table => new
                {
                    UID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    PontozoUserId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pontozas", x => x.UID);
                    table.ForeignKey(
                        name: "FK_Pontozas_AspNetUsers_PontozoUserId",
                        column: x => x.PontozoUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Pont_PontozasUID",
                table: "Pont",
                column: "PontozasUID");

            migrationBuilder.CreateIndex(
                name: "IX_Pontozas_PontozoUserId",
                table: "Pontozas",
                column: "PontozoUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Pont_Pontozas_PontozasUID",
                table: "Pont",
                column: "PontozasUID",
                principalTable: "Pontozas",
                principalColumn: "UID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
