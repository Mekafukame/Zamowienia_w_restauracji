using Microsoft.EntityFrameworkCore.Migrations;

namespace Zamowienia_w_restauracji.Data.Migrations
{
    public partial class Initial6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "USer_ID",
                table: "Zamowienie",
                newName: "User_ID");

            migrationBuilder.AddColumn<string>(
                name: "Imie",
                table: "Zamowienie",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Kod_pocztowy",
                table: "Zamowienie",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Miasto",
                table: "Zamowienie",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Nazwisko",
                table: "Zamowienie",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Nr_domu",
                table: "Zamowienie",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Nr_lokalu",
                table: "Zamowienie",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Ulica",
                table: "Zamowienie",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Imie",
                table: "Zamowienie");

            migrationBuilder.DropColumn(
                name: "Kod_pocztowy",
                table: "Zamowienie");

            migrationBuilder.DropColumn(
                name: "Miasto",
                table: "Zamowienie");

            migrationBuilder.DropColumn(
                name: "Nazwisko",
                table: "Zamowienie");

            migrationBuilder.DropColumn(
                name: "Nr_domu",
                table: "Zamowienie");

            migrationBuilder.DropColumn(
                name: "Nr_lokalu",
                table: "Zamowienie");

            migrationBuilder.DropColumn(
                name: "Ulica",
                table: "Zamowienie");

            migrationBuilder.RenameColumn(
                name: "User_ID",
                table: "Zamowienie",
                newName: "USer_ID");
        }
    }
}
