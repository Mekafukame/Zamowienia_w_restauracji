using Microsoft.EntityFrameworkCore.Migrations;

namespace Zamowienia_w_restauracji.Data.Migrations
{
    public partial class Initial7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "Cena",
                table: "Zamowienie",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<int>(
                name: "Ilosc",
                table: "Zamowienie",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Cena",
                table: "Zamowienie");

            migrationBuilder.DropColumn(
                name: "Ilosc",
                table: "Zamowienie");
        }
    }
}
