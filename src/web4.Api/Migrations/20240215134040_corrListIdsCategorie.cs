using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Events.Api.Migrations
{
    /// <inheritdoc />
    public partial class corrListIdsCategorie : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Categories_Evenements_EvenementId",
                table: "Categories");

            migrationBuilder.DropIndex(
                name: "IX_Categories_EvenementId",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "EvenementId",
                table: "Categories");

            migrationBuilder.AddColumn<List<int>>(
                name: "CategorieIds",
                table: "Evenements",
                type: "integer[]",
                nullable: false);

            migrationBuilder.AddColumn<List<int>>(
                name: "ParticipationIds",
                table: "Evenements",
                type: "integer[]",
                nullable: true);

            migrationBuilder.AddColumn<List<int>>(
                name: "VilleNom",
                table: "Evenements",
                type: "text",
                nullable: false);

            migrationBuilder.AddColumn<List<int>>(
                name: "Categories",
                table: "Evenements",
                type: "text[]",
                nullable: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CategorieIds",
                table: "Evenements");

            migrationBuilder.AddColumn<int>(
                name: "EvenementId",
                table: "Categories",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Categories_EvenementId",
                table: "Categories",
                column: "EvenementId");

            migrationBuilder.AddForeignKey(
                name: "FK_Categories_Evenements_EvenementId",
                table: "Categories",
                column: "EvenementId",
                principalTable: "Evenements",
                principalColumn: "Id");
        }
    }
}
