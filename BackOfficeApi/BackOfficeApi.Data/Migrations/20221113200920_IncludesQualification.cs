﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BackOfficeApi.Data.Migrations
{
    /// <inheritdoc />
    public partial class IncludesQualification : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Qualification",
                table: "NaturalPersons",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Qualification",
                table: "LegalPersons",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NaturalPersonId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Departments_NaturalPersons_NaturalPersonId",
                        column: x => x.NaturalPersonId,
                        principalTable: "NaturalPersons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Departments_NaturalPersonId",
                table: "Departments",
                column: "NaturalPersonId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Departments");

            migrationBuilder.DropColumn(
                name: "Qualification",
                table: "NaturalPersons");

            migrationBuilder.DropColumn(
                name: "Qualification",
                table: "LegalPersons");
        }
    }
}
