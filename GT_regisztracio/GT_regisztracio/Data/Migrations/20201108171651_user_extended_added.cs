using Microsoft.EntityFrameworkCore.Migrations;

namespace GT_regisztracio.Data.Migrations
{
    public partial class user_extended_added : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pontozas_Eredmenyek_EredmenyUID",
                table: "Pontozas");

            migrationBuilder.DropForeignKey(
                name: "FK_Pontozas_AspNetUsers_IdentityUserWithPontokId",
                table: "Pontozas");

            migrationBuilder.DropForeignKey(
                name: "FK_Pontozas_Szervezok_SzervezoUID",
                table: "Pontozas");

            migrationBuilder.DropTable(
                name: "Eredmenyek");

            migrationBuilder.DropIndex(
                name: "IX_Pontozas_EredmenyUID",
                table: "Pontozas");

            migrationBuilder.DropIndex(
                name: "IX_Pontozas_IdentityUserWithPontokId",
                table: "Pontozas");

            migrationBuilder.DropIndex(
                name: "IX_Pontozas_SzervezoUID",
                table: "Pontozas");

            migrationBuilder.DropColumn(
                name: "EredmenyUID",
                table: "Pontozas");

            migrationBuilder.DropColumn(
                name: "IdentityUserWithPontokId",
                table: "Pontozas");

            migrationBuilder.DropColumn(
                name: "Szemelyiseg",
                table: "Pontozas");

            migrationBuilder.DropColumn(
                name: "SzervezoKepesseg",
                table: "Pontozas");

            migrationBuilder.DropColumn(
                name: "SzervezoUID",
                table: "Pontozas");

            migrationBuilder.DropColumn(
                name: "Tapasztalat",
                table: "Pontozas");

            migrationBuilder.AddColumn<string>(
                name: "PontozoUserId",
                table: "Pontozas",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Pont",
                columns: table => new
                {
                    UID = table.Column<string>(nullable: false),
                    SzervezoUID = table.Column<string>(nullable: true),
                    Tapasztalat = table.Column<int>(nullable: false),
                    SzervezoKepesseg = table.Column<int>(nullable: false),
                    Szemelyiseg = table.Column<int>(nullable: false),
                    PontozasUID = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pont", x => x.UID);
                    table.ForeignKey(
                        name: "FK_Pont_Pontozas_PontozasUID",
                        column: x => x.PontozasUID,
                        principalTable: "Pontozas",
                        principalColumn: "UID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Pont_Szervezok_SzervezoUID",
                        column: x => x.SzervezoUID,
                        principalTable: "Szervezok",
                        principalColumn: "UID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Pontozas_PontozoUserId",
                table: "Pontozas",
                column: "PontozoUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Pont_PontozasUID",
                table: "Pont",
                column: "PontozasUID");

            migrationBuilder.CreateIndex(
                name: "IX_Pont_SzervezoUID",
                table: "Pont",
                column: "SzervezoUID");

            migrationBuilder.AddForeignKey(
                name: "FK_Pontozas_AspNetUsers_PontozoUserId",
                table: "Pontozas",
                column: "PontozoUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pontozas_AspNetUsers_PontozoUserId",
                table: "Pontozas");

            migrationBuilder.DropTable(
                name: "Pont");

            migrationBuilder.DropIndex(
                name: "IX_Pontozas_PontozoUserId",
                table: "Pontozas");

            migrationBuilder.DropColumn(
                name: "PontozoUserId",
                table: "Pontozas");

            migrationBuilder.AddColumn<string>(
                name: "EredmenyUID",
                table: "Pontozas",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "IdentityUserWithPontokId",
                table: "Pontozas",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Szemelyiseg",
                table: "Pontozas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SzervezoKepesseg",
                table: "Pontozas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "SzervezoUID",
                table: "Pontozas",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Tapasztalat",
                table: "Pontozas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Eredmenyek",
                columns: table => new
                {
                    UID = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Eredmenyek", x => x.UID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Pontozas_EredmenyUID",
                table: "Pontozas",
                column: "EredmenyUID");

            migrationBuilder.CreateIndex(
                name: "IX_Pontozas_IdentityUserWithPontokId",
                table: "Pontozas",
                column: "IdentityUserWithPontokId");

            migrationBuilder.CreateIndex(
                name: "IX_Pontozas_SzervezoUID",
                table: "Pontozas",
                column: "SzervezoUID");

            migrationBuilder.AddForeignKey(
                name: "FK_Pontozas_Eredmenyek_EredmenyUID",
                table: "Pontozas",
                column: "EredmenyUID",
                principalTable: "Eredmenyek",
                principalColumn: "UID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Pontozas_AspNetUsers_IdentityUserWithPontokId",
                table: "Pontozas",
                column: "IdentityUserWithPontokId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Pontozas_Szervezok_SzervezoUID",
                table: "Pontozas",
                column: "SzervezoUID",
                principalTable: "Szervezok",
                principalColumn: "UID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
