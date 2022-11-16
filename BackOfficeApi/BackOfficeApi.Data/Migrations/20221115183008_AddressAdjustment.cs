using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BackOfficeApi.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddressAdjustment : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Endereco",
                table: "NaturalPersons",
                newName: "Address");

            migrationBuilder.RenameColumn(
                name: "Endereco",
                table: "LegalPersons",
                newName: "Address");

            migrationBuilder.AddColumn<string>(
                name: "Cep",
                table: "NaturalPersons",
                type: "varchar(8)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Complement",
                table: "NaturalPersons",
                type: "varchar(100)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Number",
                table: "NaturalPersons",
                type: "varchar(100)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Cep",
                table: "LegalPersons",
                type: "varchar(8)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Complement",
                table: "LegalPersons",
                type: "varchar(100)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Number",
                table: "LegalPersons",
                type: "varchar(100)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Cep",
                table: "NaturalPersons");

            migrationBuilder.DropColumn(
                name: "Complement",
                table: "NaturalPersons");

            migrationBuilder.DropColumn(
                name: "Number",
                table: "NaturalPersons");

            migrationBuilder.DropColumn(
                name: "Cep",
                table: "LegalPersons");

            migrationBuilder.DropColumn(
                name: "Complement",
                table: "LegalPersons");

            migrationBuilder.DropColumn(
                name: "Number",
                table: "LegalPersons");

            migrationBuilder.RenameColumn(
                name: "Address",
                table: "NaturalPersons",
                newName: "Endereco");

            migrationBuilder.RenameColumn(
                name: "Address",
                table: "LegalPersons",
                newName: "Endereco");
        }
    }
}
