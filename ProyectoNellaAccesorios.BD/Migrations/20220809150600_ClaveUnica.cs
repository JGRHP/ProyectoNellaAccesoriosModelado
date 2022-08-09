using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProyectoNellaAccesorios.BD.Migrations
{
    public partial class ClaveUnica : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "UsuarioNombre_UQ",
                table: "Usuarios",
                column: "NombreUsuario",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "UsuarioNombre_UQ",
                table: "Usuarios");
        }
    }
}
