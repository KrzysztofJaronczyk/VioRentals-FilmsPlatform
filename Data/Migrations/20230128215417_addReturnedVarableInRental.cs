using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VioRentals.Data.Migrations
{
    public partial class addReturnedVarableInRental : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Returned",
                table: "Rentals",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Returned",
                table: "Rentals");
        }
    }
}
