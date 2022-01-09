using Microsoft.EntityFrameworkCore.Migrations;

namespace Zamowienia_w_restauracji.Data.Migrations
{
    public partial class Initial2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Adres",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserID = table.Column<int>(nullable: false),
                    Miasto = table.Column<string>(nullable: true),
                    Kod_pocztowy = table.Column<string>(nullable: true),
                    Ulica = table.Column<string>(nullable: true),
                    Nr_domu = table.Column<string>(nullable: true),
                    Nr_lokalu = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Adres", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Adres");
        }
    }
}
