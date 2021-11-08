using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace P2_AP1_Junior_20190009.Migrations
{
    public partial class MigracionInicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Proyectos",
                columns: table => new
                {
                    TipoId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Fecha = table.Column<DateTime>(type: "TEXT", nullable: false),
                    DescripcionProyecto = table.Column<string>(type: "TEXT", nullable: true),
                    TiempoTotal = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Proyectos", x => x.TipoId);
                });

            migrationBuilder.CreateTable(
                name: "Tareas",
                columns: table => new
                {
                    TareaId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    TipoTarea = table.Column<string>(type: "TEXT", nullable: true),
                    FechaTarea = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Tiempo = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tareas", x => x.TareaId);
                });

            migrationBuilder.CreateTable(
                name: "ProyectosDetalle",
                columns: table => new
                {
                    DetalleId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    TipoId = table.Column<int>(type: "INTEGER", nullable: false),
                    TipoTarea = table.Column<string>(type: "TEXT", nullable: true),
                    Requerimentos = table.Column<string>(type: "TEXT", nullable: true),
                    Tiempo = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProyectosDetalle", x => x.DetalleId);
                    table.ForeignKey(
                        name: "FK_ProyectosDetalle_Proyectos_TipoId",
                        column: x => x.TipoId,
                        principalTable: "Proyectos",
                        principalColumn: "TipoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TareasDetalle",
                columns: table => new
                {
                    TareaId = table.Column<int>(type: "INTEGER", nullable: false),
                    TipoTarea = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TareasDetalle", x => x.TareaId);
                    table.ForeignKey(
                        name: "FK_TareasDetalle_Tareas_TareaId",
                        column: x => x.TareaId,
                        principalTable: "Tareas",
                        principalColumn: "TareaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Tareas",
                columns: new[] { "TareaId", "FechaTarea", "Tiempo", "TipoTarea" },
                values: new object[] { 1, new DateTime(2021, 11, 8, 17, 16, 48, 400, DateTimeKind.Local).AddTicks(823), 0, "Analisis" });

            migrationBuilder.InsertData(
                table: "Tareas",
                columns: new[] { "TareaId", "FechaTarea", "Tiempo", "TipoTarea" },
                values: new object[] { 2, new DateTime(2021, 11, 8, 17, 16, 48, 400, DateTimeKind.Local).AddTicks(9871), 0, "Diseño" });

            migrationBuilder.InsertData(
                table: "Tareas",
                columns: new[] { "TareaId", "FechaTarea", "Tiempo", "TipoTarea" },
                values: new object[] { 3, new DateTime(2021, 11, 8, 17, 16, 48, 400, DateTimeKind.Local).AddTicks(9883), 0, "Programación" });

            migrationBuilder.InsertData(
                table: "Tareas",
                columns: new[] { "TareaId", "FechaTarea", "Tiempo", "TipoTarea" },
                values: new object[] { 4, new DateTime(2021, 11, 8, 17, 16, 48, 400, DateTimeKind.Local).AddTicks(9885), 0, "Prueba" });

            migrationBuilder.CreateIndex(
                name: "IX_ProyectosDetalle_TipoId",
                table: "ProyectosDetalle",
                column: "TipoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProyectosDetalle");

            migrationBuilder.DropTable(
                name: "TareasDetalle");

            migrationBuilder.DropTable(
                name: "Proyectos");

            migrationBuilder.DropTable(
                name: "Tareas");
        }
    }
}
