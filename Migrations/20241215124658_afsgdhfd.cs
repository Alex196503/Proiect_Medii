using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Proiect_Medii.Migrations
{
    /// <inheritdoc />
    public partial class afsgdhfd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Teren_CategoriiTeren_CategoriiTerenID",
                table: "Teren");

            migrationBuilder.DropTable(
                name: "CategoriiTeren");

            migrationBuilder.DropIndex(
                name: "IX_Teren_CategoriiTerenID",
                table: "Teren");

            migrationBuilder.DropColumn(
                name: "CategorieID",
                table: "Teren");

            migrationBuilder.DropColumn(
                name: "CategoriiTerenID",
                table: "Teren");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CategorieID",
                table: "Teren",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CategoriiTerenID",
                table: "Teren",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "CategoriiTeren",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nume = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoriiTeren", x => x.ID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Teren_CategoriiTerenID",
                table: "Teren",
                column: "CategoriiTerenID");

            migrationBuilder.AddForeignKey(
                name: "FK_Teren_CategoriiTeren_CategoriiTerenID",
                table: "Teren",
                column: "CategoriiTerenID",
                principalTable: "CategoriiTeren",
                principalColumn: "ID");
        }
    }
}
