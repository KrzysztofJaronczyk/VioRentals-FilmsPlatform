using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VioRentals.Data.Migrations
{
    public partial class AddSeperateGenresClass : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<byte>(
                name: "NumberInStock",
                table: "Movies",
                type: "tinyint",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Movies",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<byte>(
                name: "GenreId",
                table: "Movies",
                type: "tinyint",
                nullable: false,
                defaultValue: (byte)0);

            migrationBuilder.CreateTable(
                name: "Genres",
                columns: table => new
                {
                    Id = table.Column<byte>(type: "tinyint", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genres", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Movies_GenreId",
                table: "Movies",
                column: "GenreId");

            migrationBuilder.AddForeignKey(
                name: "FK_Movies_Genres_GenreId",
                table: "Movies",
                column: "GenreId",
                principalTable: "Genres",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.Sql("INSERT INTO Genres (Id, Name) VALUES (1, 'Action')");
            migrationBuilder.Sql("INSERT INTO Genres (Id, Name) VALUES (2, 'Comedy')");
            migrationBuilder.Sql("INSERT INTO Genres (Id, Name) VALUES (3, 'Family')");
            migrationBuilder.Sql("INSERT INTO Genres (Id, Name) VALUES (4, 'Romance')");
            migrationBuilder.Sql("INSERT INTO Genres (Id, Name) VALUES (5, 'Thriller')");
            migrationBuilder.Sql("INSERT INTO Genres (Id, Name) VALUES (6, 'Horror')");
            migrationBuilder.Sql("INSERT INTO Genres (Id, Name) VALUES (7, 'Drama')");
            migrationBuilder.Sql("INSERT INTO Genres (Id, Name) VALUES (8, 'Sci-Fi')");
            migrationBuilder.Sql("INSERT INTO Genres (Id, Name) VALUES (9, 'Fantasy')");
            migrationBuilder.Sql("INSERT INTO Genres (Id, Name) VALUES (10, 'Mystery')");
            migrationBuilder.Sql("INSERT INTO Genres (Id, Name) VALUES (11, 'Western')");
            migrationBuilder.Sql("INSERT INTO Genres (Id, Name) VALUES (12, 'Animation')");
            migrationBuilder.Sql("INSERT INTO Genres (Id, Name) VALUES (13, 'Adventure')");
            migrationBuilder.Sql("INSERT INTO Genres (Id, Name) VALUES (14, 'Crime')");
            migrationBuilder.Sql("INSERT INTO Genres (Id, Name) VALUES (15, 'Documentary')");
            migrationBuilder.Sql("INSERT INTO Genres (Id, Name) VALUES (16, 'History')");
            migrationBuilder.Sql("INSERT INTO Genres (Id, Name) VALUES (17, 'Music')");
            migrationBuilder.Sql("INSERT INTO Genres (Id, Name) VALUES (18, 'War')");
            migrationBuilder.Sql("INSERT INTO Genres (Id, Name) VALUES (19, 'Biography')");
            migrationBuilder.Sql("INSERT INTO Genres (Id, Name) VALUES (20, 'Musical')");


            migrationBuilder.Sql("INSERT INTO Movies (Name, ReleaseDate, DateAdded, NumberInStock, GenreId) VALUES ('Hangover', '2009-06-05', '2015-06-05', 5, 2)");
            migrationBuilder.Sql("INSERT INTO Movies (Name, ReleaseDate, DateAdded, NumberInStock, GenreId) VALUES ('Die Hard', '1988-07-12', '2015-06-05', 5, 1)");
            migrationBuilder.Sql("INSERT INTO Movies (Name, ReleaseDate, DateAdded, NumberInStock, GenreId) VALUES ('The Terminator', '1984-10-26', '2015-06-05', 5, 1)");
            migrationBuilder.Sql("INSERT INTO Movies (Name, ReleaseDate, DateAdded, NumberInStock, GenreId) VALUES ('Toy Story', '1995-11-22', '2015-06-05', 5, 3)");
            migrationBuilder.Sql("INSERT INTO Movies (Name, ReleaseDate, DateAdded, NumberInStock, GenreId) VALUES ('Titanic', '1997-12-19', '2015-06-05', 5, 4)");
            migrationBuilder.Sql("INSERT INTO Movies (Name, ReleaseDate, DateAdded, NumberInStock, GenreId) VALUES ('The Sixth Sense', '1999-08-06', '2015-06-05', 5, 5)");
            migrationBuilder.Sql("INSERT INTO Movies (Name, ReleaseDate, DateAdded, NumberInStock, GenreId) VALUES ('The Avengers', '2012-04-25', '2015-06-05', 5, 1)");
            migrationBuilder.Sql("INSERT INTO Movies (Name, ReleaseDate, DateAdded, NumberInStock, GenreId) VALUES ('The Dark Knight', '2008-07-18', '2015-06-05', 5, 1)");
            migrationBuilder.Sql("INSERT INTO Movies (Name, ReleaseDate, DateAdded, NumberInStock, GenreId) VALUES ('The Lion King', '1994-06-23', '2015-06-05', 5, 3)");
            migrationBuilder.Sql("INSERT INTO Movies (Name, ReleaseDate, DateAdded, NumberInStock, GenreId) VALUES ('Star Wars', '1977-05-25', '2015-06-05', 5, 1)");
            migrationBuilder.Sql("INSERT INTO Movies (Name, ReleaseDate, DateAdded, NumberInStock, GenreId) VALUES ('The Incredibles', '2004-11-05', '2015-06-05', 5, 3)");
            migrationBuilder.Sql("INSERT INTO Movies (Name, ReleaseDate, DateAdded, NumberInStock, GenreId) VALUES ('The Matrix', '1999-03-31', '2015-06-05', 5, 8)");
            migrationBuilder.Sql("INSERT INTO Movies (Name, ReleaseDate, DateAdded, NumberInStock, GenreId) VALUES ('Forrest Gump', '1994-07-06', '2015-06-05', 5, 7)");
            migrationBuilder.Sql("INSERT INTO Movies (Name, ReleaseDate, DateAdded, NumberInStock, GenreId) VALUES ('The Lord of the Rings: The Fellowship of the Ring', '2001-12-19', '2015-06-05', 5, 13)");
            migrationBuilder.Sql("INSERT INTO Movies (Name, ReleaseDate, DateAdded, NumberInStock, GenreId) VALUES ('The Lord of the Rings: The Two Towers', '2002-12-18', '2015-06-05', 5, 13)");
            migrationBuilder.Sql("INSERT INTO Movies (Name, ReleaseDate, DateAdded, NumberInStock, GenreId) VALUES ('The Lord of the Rings: The Return of the King', '2003-12-17', '2015-06-05', 5, 13)");
            migrationBuilder.Sql("INSERT INTO Movies (Name, ReleaseDate, DateAdded, NumberInStock, GenreId) VALUES ('The Hunger Games', '2012-03-23', '2015-06-05', 5, 13)");
            migrationBuilder.Sql("INSERT INTO Movies (Name, ReleaseDate, DateAdded, NumberInStock, GenreId) VALUES ('The Hunger Games: Catching Fire', '2013-11-22', '2015-06-05', 5, 13)");
            migrationBuilder.Sql("INSERT INTO Movies (Name, ReleaseDate, DateAdded, NumberInStock, GenreId) VALUES ('The Hobbit: An Unexpected Journey', '2012-12-14', '2015-06-05', 5, 13)");
            migrationBuilder.Sql("INSERT INTO Movies (Name, ReleaseDate, DateAdded, NumberInStock, GenreId) VALUES ('The Shawshank Redemption', '1994-09-23', '2015-06-05', 5, 6)");
            migrationBuilder.Sql("INSERT INTO Movies (Name, ReleaseDate, DateAdded, NumberInStock, GenreId) VALUES ('The Godfather', '1972-03-15', '2015-06-05', 5, 6)");
            migrationBuilder.Sql("INSERT INTO Movies (Name, ReleaseDate, DateAdded, NumberInStock, GenreId) VALUES ('The Godfather: Part II', '1974-12-20', '2015-06-05', 5, 6)");
            migrationBuilder.Sql("INSERT INTO Movies (Name, ReleaseDate, DateAdded, NumberInStock, GenreId) VALUES ('The Dark Knight Rises', '2012-07-20', '2015-06-05', 5, 1)");
            migrationBuilder.Sql("INSERT INTO Movies (Name, ReleaseDate, DateAdded, NumberInStock, GenreId) VALUES ('Pulp Fiction', '1994-10-14', '2015-06-05', 5, 6)");
            migrationBuilder.Sql("INSERT INTO Movies (Name, ReleaseDate, DateAdded, NumberInStock, GenreId) VALUES ('Schindler''s List', '1993-11-30', '2015-06-05', 5, 6)");
            migrationBuilder.Sql("INSERT INTO Movies (Name, ReleaseDate, DateAdded, NumberInStock, GenreId) VALUES ('Inception', '2010-07-16', '2015-06-05', 5, 8)");
            migrationBuilder.Sql("INSERT INTO Movies (Name, ReleaseDate, DateAdded, NumberInStock, GenreId) VALUES ('Fight Club', '1999-10-15', '2015-06-05', 5, 6)");

            

            //add records to custommers
            migrationBuilder.Sql("INSERT INTO Customers (Name, Surname, IsSubscribedToNewsletter, MembershipTypeId, DateOfBirth) VALUES ('John', 'Smith', 0, 1, '1990-01-01')");
            migrationBuilder.Sql("INSERT INTO Customers (Name, Surname, IsSubscribedToNewsletter, MembershipTypeId, DateOfBirth) VALUES ('Mary', 'Williams', 1, 2, '1990-01-01')");
            migrationBuilder.Sql("INSERT INTO Customers (Name, Surname, IsSubscribedToNewsletter, MembershipTypeId, DateOfBirth) VALUES ('Robert', 'Jones', 0, 3, '1990-01-01')");
            migrationBuilder.Sql("INSERT INTO Customers (Name, Surname, IsSubscribedToNewsletter, MembershipTypeId, DateOfBirth) VALUES ('Linda', 'Brown', 1, 4, '1990-01-01')");
            migrationBuilder.Sql("INSERT INTO Customers (Name, Surname, IsSubscribedToNewsletter, MembershipTypeId, DateOfBirth) VALUES ('William', 'Davis', 0, 1, '1990-01-01')");
            migrationBuilder.Sql("INSERT INTO Customers (Name, Surname, IsSubscribedToNewsletter, MembershipTypeId, DateOfBirth) VALUES ('Michael', 'Brown', 0, 1, NULL)");
            migrationBuilder.Sql("INSERT INTO Customers (Name, Surname, IsSubscribedToNewsletter, MembershipTypeId, DateOfBirth) VALUES ('Linda', 'Davis', 1, 2, NULL)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Movies_Genres_GenreId",
                table: "Movies");

            migrationBuilder.DropTable(
                name: "Genres");

            migrationBuilder.DropIndex(
                name: "IX_Movies_GenreId",
                table: "Movies");

            migrationBuilder.DropColumn(
                name: "GenreId",
                table: "Movies");

            migrationBuilder.AlterColumn<int>(
                name: "NumberInStock",
                table: "Movies",
                type: "int",
                nullable: false,
                oldClrType: typeof(byte),
                oldType: "tinyint");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Movies",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255);

            migrationBuilder.AddColumn<string>(
                name: "Genre",
                table: "Movies",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
