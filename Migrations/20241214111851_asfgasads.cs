using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Proiect_Medii.Migrations
{
    /// <inheritdoc />Te
    public partial class asfgasads : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TerenID",
                table: "Reservation",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Teren",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tip = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Dimensiune = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teren", x => x.ID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Reservation_TerenID",
                table: "Reservation",
                column: "TerenID");

            migrationBuilder.AddForeignKey(
                name: "FK_Reservation_Teren_TerenID",
                table: "Reservation",
                column: "TerenID",
                principalTable: "Teren",
                principalColumn: "ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reservation_Teren_TerenID",
                table: "Reservation");

            migrationBuilder.DropTable(
                name: "Teren");

            migrationBuilder.DropIndex(
                name: "IX_Reservation_TerenID",
                table: "Reservation");

            migrationBuilder.DropColumn(
                name: "TerenID",
                table: "Reservation");
        }
    }
}
