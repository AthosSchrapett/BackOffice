using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BackOfficeApi.Data.Migrations
{
    /// <inheritdoc />
    public partial class InclusaoNomeDepartamento : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Nome",
                table: "Departments",
                type: "varchar(150)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Nome",
                table: "Departments");
        }
    }
}
