﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace Parcial1_Ap2_Garcia.Migrations
{
    public partial class First_Migration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "articulos",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Descripcion = table.Column<string>(nullable: false),
                    Existencia = table.Column<int>(nullable: false),
                    Costo = table.Column<decimal>(nullable: false),
                    Inventario = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_articulos", x => x.ID);
                });

            migrationBuilder.InsertData(
                table: "articulos",
                columns: new[] { "ID", "Costo", "Descripcion", "Existencia", "Inventario" },
                values: new object[] { 1, 345.34m, "Mouse Inalambrico", 34, 11741.56m });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "articulos");
        }
    }
}
