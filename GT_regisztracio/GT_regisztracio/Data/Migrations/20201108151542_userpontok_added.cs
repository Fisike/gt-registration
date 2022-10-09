using Microsoft.EntityFrameworkCore.Migrations;

namespace GT_regisztracio.Data.Migrations
{
    public partial class userpontok_added : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "Pontozas",
                columns: table => new
                {
                    UID = table.Column<string>(nullable: false),
                    SzervezoUID = table.Column<string>(nullable: true),
                    Tapasztalat = table.Column<int>(nullable: false),
                    SzervezoKepesseg = table.Column<int>(nullable: false),
                    Szemelyiseg = table.Column<int>(nullable: false),
                    IdentityUserWithPontokId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pontozas", x => x.UID);
                    table.ForeignKey(
                        name: "FK_Pontozas_AspNetUsers_IdentityUserWithPontokId",
                        column: x => x.IdentityUserWithPontokId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Pontozas_Szervezok_SzervezoUID",
                        column: x => x.SzervezoUID,
                        principalTable: "Szervezok",
                        principalColumn: "UID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Pontozas_IdentityUserWithPontokId",
                table: "Pontozas",
                column: "IdentityUserWithPontokId");

            migrationBuilder.CreateIndex(
                name: "IX_Pontozas_SzervezoUID",
                table: "Pontozas",
                column: "SzervezoUID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Pontozas");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "AspNetUsers");
        }
    }
}
