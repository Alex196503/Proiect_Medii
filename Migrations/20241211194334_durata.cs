using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Proiect_Medii.Migrations
{
    /// <inheritdoc />
    public partial class durata : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Durata",
                table: "Reservation",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Durata",
                table: "Reservation");
        }
    }
}
