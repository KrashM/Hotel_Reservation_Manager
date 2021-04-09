using Microsoft.EntityFrameworkCore.Migrations;

namespace Hotel_Reservation_Manager.Migrations
{
    public partial class FixedSpelling : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "SirName",
                table: "Clients",
                newName: "SurName");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "SurName",
                table: "Clients",
                newName: "SirName");
        }
    }
}
