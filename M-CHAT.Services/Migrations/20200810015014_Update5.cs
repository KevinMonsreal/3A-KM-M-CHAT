using Microsoft.EntityFrameworkCore.Migrations;

namespace M_CHAT.Services.Migrations
{
    public partial class Update5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Preguntas_Niños_NiñoID",
                table: "Preguntas");

            migrationBuilder.DropIndex(
                name: "IX_Preguntas_NiñoID",
                table: "Preguntas");

            migrationBuilder.DropColumn(
                name: "NiñoID",
                table: "Preguntas");

            migrationBuilder.DropColumn(
                name: "Valor",
                table: "Preguntas");

            migrationBuilder.AddColumn<bool>(
                name: "Respuesta",
                table: "Preguntas",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "PreguntasId",
                table: "Niños",
                nullable: true);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Niños_Preguntas_PreguntasId",
                table: "Niños");

            migrationBuilder.DropIndex(
                name: "IX_Niños_PreguntasId",
                table: "Niños");

            migrationBuilder.DropColumn(
                name: "Respuesta",
                table: "Preguntas");

            migrationBuilder.DropColumn(
                name: "PreguntasId",
                table: "Niños");

            migrationBuilder.AddColumn<int>(
                name: "NiñoID",
                table: "Preguntas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Valor",
                table: "Preguntas",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Preguntas_NiñoID",
                table: "Preguntas",
                column: "NiñoID",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Preguntas_Niños_NiñoID",
                table: "Preguntas",
                column: "NiñoID",
                principalTable: "Niños",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
