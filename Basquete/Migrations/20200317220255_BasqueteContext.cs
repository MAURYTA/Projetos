using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Basquete.Migrations
{
    public partial class BasqueteContext : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Ponto",
                columns: table => new
                {
                    JogoID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PontoTimeA = table.Column<int>(nullable: false),
                    PontoTimeB = table.Column<int>(nullable: false),
                    DataPartida = table.Column<DateTime>(nullable: false),
                    Resultado = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ponto", x => x.JogoID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ponto");
        }
    }
}
