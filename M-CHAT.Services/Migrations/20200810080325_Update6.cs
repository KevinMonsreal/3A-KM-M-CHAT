using Microsoft.EntityFrameworkCore.Migrations;

namespace M_CHAT.Services.Migrations
{
    public partial class Update6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Niños_Preguntas_PreguntasId",
                table: "Niños");

            migrationBuilder.DropTable(
                name: "Cuentas");

            migrationBuilder.DropIndex(
                name: "IX_Niños_PreguntasId",
                table: "Niños");

            migrationBuilder.DropColumn(
                name: "PreguntasId",
                table: "Niños");

            migrationBuilder.AddColumn<string>(
                name: "Estado",
                table: "Niños",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Estado",
                table: "Niños");

            migrationBuilder.AddColumn<int>(
                name: "PreguntasId",
                table: "Niños",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Cuentas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Contraseña = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Correo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cuentas", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Niños_PreguntasId",
                table: "Niños",
                column: "PreguntasId");

            migrationBuilder.AddForeignKey(
                name: "FK_Niños_Preguntas_PreguntasId",
                table: "Niños",
                column: "PreguntasId",
                principalTable: "Preguntas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
