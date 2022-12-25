using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VioRentals.Data.Migrations
{
    public partial class addNameToMembership : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "MembershipType",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "Movies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movies", x => x.Id);
                });
            //insert a value to database
            migrationBuilder.Sql("INSERT INTO MembershipType (Id, Name, SignUpFee, DurationInMonths, DiscountRate) VALUES (1, 'Pay as You Go', 0, 0, 0)");
            migrationBuilder.Sql("INSERT INTO MembershipType (Id, Name, SignUpFee, DurationInMonths, DiscountRate) VALUES (2, 'Monthly', 30, 1, 10)");
            migrationBuilder.Sql("INSERT INTO MembershipType (Id, Name, SignUpFee, DurationInMonths, DiscountRate) VALUES (3, 'Quarterly', 90, 3, 15)");
            migrationBuilder.Sql("INSERT INTO MembershipType (Id, Name, SignUpFee, DurationInMonths, DiscountRate) VALUES (4, 'Annual', 300, 12, 20)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Movies");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "MembershipType");
        }
    }
}
