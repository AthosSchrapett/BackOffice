using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BackOfficeApi.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddressAdjustmentNew : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Bairro",
                table: "NaturalPersons",
                type: "varchar(100)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Cidade",
                table: "NaturalPersons",
                type: "varchar(100)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Uf",
                table: "NaturalPersons",
                type: "varchar(100)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Bairro",
                table: "LegalPersons",
                type: "varchar(100)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Cidade",
                table: "LegalPersons",
                type: "varchar(100)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Uf",
                table: "LegalPersons",
                type: "varchar(100)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Bairro",
                table: "NaturalPersons");

            migrationBuilder.DropColumn(
                name: "Cidade",
                table: "NaturalPersons");

            migrationBuilder.DropColumn(
                name: "Uf",
                table: "NaturalPersons");

            migrationBuilder.DropColumn(
                name: "Bairro",
                table: "LegalPersons");

            migrationBuilder.DropColumn(
                name: "Cidade",
                table: "LegalPersons");

            migrationBuilder.DropColumn(
                name: "Uf",
                table: "LegalPersons");
        }
    }
}
