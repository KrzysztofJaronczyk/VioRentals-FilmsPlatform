using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VioRentals.Data.Migrations
{
    public partial class AddUserRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // insert into AspNetUsers
            migrationBuilder.Sql("INSERT INTO AspNetUsers (Id, Username, NormalizedUserName, Email, NormalizedEmail, EmailConfirmed, PasswordHash, SecurityStamp, ConcurrencyStamp, PhoneNumber, PhoneNumberConfirmed, TwoFactorEnabled, LockoutEnd, LockoutEnabled, AccessFailedCount) VALUES ('1a7d5a40-837b-4344-9061-014b48635dfc', 'employee@gmail.com', 'EMPLOYEE@GMAIL.COM', 'employee@gmail.com', 'EMPLOYEE@GMAIL.COM', 'True', 'AQAAAAEAACcQAAAAED2XYNtarnIgbo5FJltcsw1Vqfz78JN82Z7ag5ErwtOOLAEMpIMYFvxA9uGTe6hbhg==', 'XF34WLXJ7P2MSPO5CTF3YG6CY2VXKTVS', 'ce0f9cd1-0807-47a2-9916-da2350c838fd', null, 'False', 'False', '2023-01-27 00:00:00', 'True', 0)");

            migrationBuilder.Sql("INSERT INTO AspNetUsers (Id, Username, NormalizedUserName, Email, NormalizedEmail, EmailConfirmed, PasswordHash, SecurityStamp, ConcurrencyStamp, PhoneNumber, PhoneNumberConfirmed, TwoFactorEnabled, LockoutEnd, LockoutEnabled, AccessFailedCount) VALUES ('a54d9479-a2f6-4b3e-bf5e-1098db73e8f6', 'admin@gmail.com', 'ADMIN@GMAIL.COM', 'admin@gmail.com', 'ADMIN@GMAIL.COM', 'True' ,'AQAAAAEAACcQAAAAEJBavLtLY96Wop1BkYNJPbaN1vK0hc0ERLstslN/LTnRvPrPtgaE2q8X+3F35HsutA==', 'RU57UYTZ6HA62E3LHZMA57Q2N7LRYF7I', '337b16fb-9f9e-4183-9b35-a8275628dd66', null, 'False', 'False', '2023-01-27 00:00:00', 'True', 0)");
            // insert into AspNetRoles
            migrationBuilder.Sql("INSERT INTO AspNetRoles (Id, Name, NormalizedName, ConcurrencyStamp) VALUES" +
                                 " ('7e60218b-a99b-4df0-b05d-4bacbab549af', 'Admin', 'ADMIN', '96fd4175-7920-4925-9b63-fd9f1bf21cd7')");
            migrationBuilder.Sql("INSERT INTO AspNetRoles (Id, Name, NormalizedName, ConcurrencyStamp) VALUES" +
                                 " ('69982d63-a448-4643-8374-425070926b92', 'Employee', 'EMPLOYEE', '89c83658-537c-45da-a4e0-fd1ba51bc0c2')");

            // insert into AspNetUserRoles
            migrationBuilder.Sql("INSERT INTO AspNetUserRoles (UserId, RoleId) VALUES" +
                                 " ('1a7d5a40-837b-4344-9061-014b48635dfc', '69982d63-a448-4643-8374-425070926b92')");
            migrationBuilder.Sql("INSERT INTO AspNetUserRoles (UserId, RoleId) VALUES" +
                                 " ('a54d9479-a2f6-4b3e-bf5e-1098db73e8f6', '7e60218b-a99b-4df0-b05d-4bacbab549af')");



        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
