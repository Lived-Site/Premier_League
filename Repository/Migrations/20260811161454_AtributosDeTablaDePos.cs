using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Repository.Migrations
{
    /// <inheritdoc />
    public partial class AtributosDeTablaDePos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "GolesAFavor",
                table: "Equipos",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "GolesRecibidos",
                table: "Equipos",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PartidosEmpatados",
                table: "Equipos",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PartidosGanados",
                table: "Equipos",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PartidosJugados",
                table: "Equipos",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PartidosPerdidos",
                table: "Equipos",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "GolesAFavor",
                table: "Equipos");

            migrationBuilder.DropColumn(
                name: "GolesRecibidos",
                table: "Equipos");

            migrationBuilder.DropColumn(
                name: "PartidosEmpatados",
                table: "Equipos");

            migrationBuilder.DropColumn(
                name: "PartidosGanados",
                table: "Equipos");

            migrationBuilder.DropColumn(
                name: "PartidosJugados",
                table: "Equipos");

            migrationBuilder.DropColumn(
                name: "PartidosPerdidos",
                table: "Equipos");
        }
    }
}
