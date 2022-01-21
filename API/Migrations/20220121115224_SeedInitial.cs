using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DesafioChallengeSPA.Migrations
{
    public partial class SeedInitial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Profissao",
                columns: new[] { "Id", "Nome" },
                values: new object[,]
                {
                    { 1, "Programador" },
                    { 2, "Analista" },
                    { 3, "Scrum Master" },
                    { 4, "DevOps" }
                });

            migrationBuilder.InsertData(
                table: "Cliente",
                columns: new[] { "Id", "CPF", "DataNascimento", "Idade", "Nome", "ProfissaoId", "Sobrenome" },
                values: new object[,]
                {
                    { 1, "52665483041", new DateTime(1997, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 24, "Raul", 1, "Marciano" },
                    { 2, "99257878074", new DateTime(1995, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 26, "José Antonio", 2, "Oliveira" },
                    { 3, "42257300009", new DateTime(1998, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 23, "Maria", 3, "Aparecida" },
                    { 4, "29671743005", new DateTime(1996, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 25, "Isabela Genes", 4, "Dutra" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cliente",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Cliente",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Cliente",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Cliente",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Profissao",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Profissao",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Profissao",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Profissao",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
