using Microsoft.EntityFrameworkCore.Migrations;

namespace P2_AP1_CarlosLopez_20190720.Migrations
{
    public partial class Migracion_Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TiposTareas",
                columns: table => new
                {
                    TipoId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    TipoTarea = table.Column<string>(type: "TEXT", nullable: true),
                    Requerimiento = table.Column<string>(type: "TEXT", nullable: true),
                    Tiempo = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TiposTareas", x => x.TipoId);
                });

            migrationBuilder.InsertData(
                table: "TiposTareas",
                columns: new[] { "TipoId", "Requerimiento", "Tiempo", "TipoTarea" },
                values: new object[] { 1, "Analizar la opcion de clientes", 120, "Analisis" });

            migrationBuilder.InsertData(
                table: "TiposTareas",
                columns: new[] { "TipoId", "Requerimiento", "Tiempo", "TipoTarea" },
                values: new object[] { 2, "Hacer un diseño excelente", 60, "Diseño" });

            migrationBuilder.InsertData(
                table: "TiposTareas",
                columns: new[] { "TipoId", "Requerimiento", "Tiempo", "TipoTarea" },
                values: new object[] { 3, "Programar todo el registro", 240, "Programacion" });

            migrationBuilder.InsertData(
                table: "TiposTareas",
                columns: new[] { "TipoId", "Requerimiento", "Tiempo", "TipoTarea" },
                values: new object[] { 4, "Probar con mucho cuidado", 30, "Prueba" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TiposTareas");
        }
    }
}
