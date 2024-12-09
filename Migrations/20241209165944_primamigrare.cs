using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Proiect_Medii.Migrations
{
    /// <inheritdoc />
    public partial class primamigrare : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MembershipID",
                table: "Member",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Membership",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MembershipName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Data_Start = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Data_Expirare = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Membership", x => x.ID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Member_MembershipID",
                table: "Member",
                column: "MembershipID");

            migrationBuilder.AddForeignKey(
                name: "FK_Member_Membership_MembershipID",
                table: "Member",
                column: "MembershipID",
                principalTable: "Membership",
                principalColumn: "ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Member_Membership_MembershipID",
                table: "Member");

            migrationBuilder.DropTable(
                name: "Membership");

            migrationBuilder.DropIndex(
                name: "IX_Member_MembershipID",
                table: "Member");

            migrationBuilder.DropColumn(
                name: "MembershipID",
                table: "Member");
        }
    }
}
