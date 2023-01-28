using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VioRentals.Data.Migrations
{
    public partial class AddMoreRecords : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {


            migrationBuilder.CreateTable(
                name: "MovieDto",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    GenreId = table.Column<byte>(type: "tinyint", nullable: false),
                    DateAdded = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ReleaseDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NumberInStock = table.Column<byte>(type: "tinyint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MovieDto", x => x.Id);
                });
            //add movies
            migrationBuilder.Sql("INSERT INTO Movies (Name, ReleaseDate, DateAdded, NumberInStock, GenreId) VALUES ('Avengers: Age of Ultron', '2015-05-01', '2023-01-27', 5, 1)");
            migrationBuilder.Sql("INSERT INTO Movies (Name, ReleaseDate, DateAdded, NumberInStock, GenreId) VALUES ('Avatar', '2009-12-18', '2023-01-27', 6, 8)");
            migrationBuilder.Sql("INSERT INTO Movies (Name, ReleaseDate, DateAdded, NumberInStock, GenreId) VALUES ('Aliens', '1986-07-18', '2023-01-27', 6, 6)");
            migrationBuilder.Sql("INSERT INTO Movies (Name, ReleaseDate, DateAdded, NumberInStock, GenreId) VALUES ('Alien', '1979-05-25', '2023-01-27', 6, 6)");
            migrationBuilder.Sql("INSERT INTO Movies (Name, ReleaseDate, DateAdded, NumberInStock, GenreId) VALUES ('Alien 3', '1992-05-22', '2023-01-27', 6, 6)");
            migrationBuilder.Sql("INSERT INTO Movies (Name, ReleaseDate, DateAdded, NumberInStock, GenreId) VALUES ('Alien: Resurrection', '1997-09-07', '2023-01-27', 6, 6)");
            migrationBuilder.Sql("INSERT INTO Movies (Name, ReleaseDate, DateAdded, NumberInStock, GenreId) VALUES ('Terminator 2: Judgment Day', '1991-07-03', '2023-01-27', 1, 8)");
            migrationBuilder.Sql("INSERT INTO Movies (Name, ReleaseDate, DateAdded, NumberInStock, GenreId) VALUES ('Terminator 3: Rise of the Machines', '2003-07-02', '2023-01-27', 1, 8)");
            migrationBuilder.Sql("INSERT INTO Movies (Name, ReleaseDate, DateAdded, NumberInStock, GenreId) VALUES ('Terminator Salvation', '2009-05-21', '2023-01-27', 1, 8)");
            migrationBuilder.Sql("INSERT INTO Movies (Name, ReleaseDate, DateAdded, NumberInStock, GenreId) VALUES ('Terminator Genisys', '2015-07-01', '2023-01-27', 1, 8)");
            migrationBuilder.Sql("INSERT INTO Movies (Name, ReleaseDate, DateAdded, NumberInStock, GenreId) VALUES ('Alien vs. Predator', '2004-08-06', '2023-01-27', 1, 6)");
            migrationBuilder.Sql("INSERT INTO Movies (Name, ReleaseDate, DateAdded, NumberInStock, GenreId) VALUES ('Terminator 2: Judgment Day', '1991-07-03', '2023-01-27', 1, 1)");
            migrationBuilder.Sql("INSERT INTO Movies (Name, ReleaseDate, DateAdded, NumberInStock, GenreId) VALUES ('Terminator 3: Rise of the Machines', '2003-07-02', '2023-01-27', 1, 1)");
            migrationBuilder.Sql("INSERT INTO Movies (Name, ReleaseDate, DateAdded, NumberInStock, GenreId) VALUES ('Terminator Salvation', '2009-05-21', '2023-01-27', 1, 1)");
            migrationBuilder.Sql("INSERT INTO Movies (Name, ReleaseDate, DateAdded, NumberInStock, GenreId) VALUES ('Terminator Genisys', '2015-07-01', '2023-01-27', 1, 1)");
            migrationBuilder.Sql("INSERT INTO Movies (Name, ReleaseDate, DateAdded, NumberInStock, GenreId) VALUES ('Alien vs. Predator', '2004-08-06', '2023-01-27', 1, 6)");
            migrationBuilder.Sql("INSERT INTO Movies (Name, ReleaseDate, DateAdded, NumberInStock, GenreId) VALUES ('The Shawshank Redemption', '1994-09-14', '2023-01-27', 1, 7)");
            migrationBuilder.Sql("INSERT INTO Movies (Name, ReleaseDate, DateAdded, NumberInStock, GenreId) VALUES ('The Godfather', '1972-03-24', '2023-01-27', 1, 14)");
            migrationBuilder.Sql("INSERT INTO Movies (Name, ReleaseDate, DateAdded, NumberInStock, GenreId) VALUES ('The Godfather: Part II', '1974-12-20', '2023-01-27', 1, 14)");
            migrationBuilder.Sql("INSERT INTO Movies (Name, ReleaseDate, DateAdded, NumberInStock, GenreId) VALUES ('The Dark Knight', '2008-07-16', '2023-01-27', 1, 14)");
            migrationBuilder.Sql("INSERT INTO Movies (Name, ReleaseDate, DateAdded, NumberInStock, GenreId) VALUES ('12 Angry Men', '1957-04-10', '2023-01-27', 1, 17)");
            migrationBuilder.Sql("INSERT INTO Movies (Name, ReleaseDate, DateAdded, NumberInStock, GenreId) VALUES ('Schindler''s List', '1993-12-15', '2023-01-27', 1, 16)");
            migrationBuilder.Sql("INSERT INTO Movies (Name, ReleaseDate, DateAdded, NumberInStock, GenreId) VALUES ('The Lord of the Rings: The Return of the King', '2003-12-17', '2023-01-27', 1, 9)");
            migrationBuilder.Sql("INSERT INTO Movies (Name, ReleaseDate, DateAdded, NumberInStock, GenreId) VALUES ('Pulp Fiction', '1994-10-14', '2023-01-27', 1, 14)");
            migrationBuilder.Sql("INSERT INTO Movies (Name, ReleaseDate, DateAdded, NumberInStock, GenreId) VALUES ('Terminator 2: Judgment Day', '1991-07-03', '2023-01-27', 1, 1)");
            migrationBuilder.Sql("INSERT INTO Movies (Name, ReleaseDate, DateAdded, NumberInStock, GenreId) VALUES ('Terminator 3: Rise of the Machines', '2003-07-02', '2023-01-27', 1, 1)");
            migrationBuilder.Sql("INSERT INTO Movies (Name, ReleaseDate, DateAdded, NumberInStock, GenreId) VALUES ('Terminator Salvation', '2009-05-21', '2023-01-27', 1, 1)");
            migrationBuilder.Sql("INSERT INTO Movies (Name, ReleaseDate, DateAdded, NumberInStock, GenreId) VALUES ('Terminator Genisys', '2015-07-01', '2023-01-27', 1, 1)");
            migrationBuilder.Sql("INSERT INTO Movies (Name, ReleaseDate, DateAdded, NumberInStock, GenreId) VALUES ('Alien vs. Predator', '2004-08-06', '2023-01-27', 1, 1)");
            migrationBuilder.Sql("INSERT INTO Movies (Name, ReleaseDate, DateAdded, NumberInStock, GenreId) VALUES ('Jurassic Park', '1993-06-11', '2023-01-27', 4, 13)");
            migrationBuilder.Sql("INSERT INTO Movies (Name, ReleaseDate, DateAdded, NumberInStock, GenreId) VALUES ('Jurassic World', '2015-06-12', '2023-01-27', 4, 13)");
            migrationBuilder.Sql("INSERT INTO Movies (Name, ReleaseDate, DateAdded, NumberInStock, GenreId) VALUES ('Jurassic World: Fallen Kingdom', '2018-06-22', '2023-01-27', 4, 13)");
            migrationBuilder.Sql("INSERT INTO Movies (Name, ReleaseDate, DateAdded, NumberInStock, GenreId) VALUES ('Jurassic World: Dominion', '2022-06-10', '2023-01-27', 4, 13)");
            migrationBuilder.Sql("INSERT INTO Movies (Name, ReleaseDate, DateAdded, NumberInStock, GenreId) VALUES ('Inception', '2010-07-16', '2023-01-27', 2, 10)");
            migrationBuilder.Sql("INSERT INTO Movies (Name, ReleaseDate, DateAdded, NumberInStock, GenreId) VALUES ('Interstellar', '2014-11-05', '2023-01-27', 2, 8)");
            migrationBuilder.Sql("INSERT INTO Movies (Name, ReleaseDate, DateAdded, NumberInStock, GenreId) VALUES ('The Shawshank Redemption', '1994-09-23', '2023-01-27', 3, 7)");
            migrationBuilder.Sql("INSERT INTO Movies (Name, ReleaseDate, DateAdded, NumberInStock, GenreId) VALUES ('The Godfather', '1972-03-24', '2023-01-27', 3, 7)");
            migrationBuilder.Sql("INSERT INTO Movies (Name, ReleaseDate, DateAdded, NumberInStock, GenreId) VALUES ('The Shawshank Redemption', '1994-09-14', '2023-01-27', 8, 7)");
            migrationBuilder.Sql("INSERT INTO Movies (Name, ReleaseDate, DateAdded, NumberInStock, GenreId) VALUES ('Forrest Gump', '1994-07-06', '2023-01-27', 5, 7)");
            migrationBuilder.Sql("INSERT INTO Movies (Name, ReleaseDate, DateAdded, NumberInStock, GenreId) VALUES ('The Green Mile', '1999-12-10', '2023-01-27', 3, 7)");
            migrationBuilder.Sql("INSERT INTO Movies (Name, ReleaseDate, DateAdded, NumberInStock, GenreId) VALUES ('The Godfather', '1972-03-24', '2023-01-27', 10, 7)");
            migrationBuilder.Sql("INSERT INTO Movies (Name, ReleaseDate, DateAdded, NumberInStock, GenreId) VALUES ('The Godfather: Part II', '1974-12-20', '2023-01-27', 8, 7)");
            migrationBuilder.Sql("INSERT INTO Movies (Name, ReleaseDate, DateAdded, NumberInStock, GenreId) VALUES ('The Godfather: Part III', '1990-12-24', '2023-01-27', 5, 7)");
            migrationBuilder.Sql("INSERT INTO Movies (Name, ReleaseDate, DateAdded, NumberInStock, GenreId) VALUES ('The Silence of the Lambs', '1991-02-14', '2023-01-27', 7, 10)");
            migrationBuilder.Sql("INSERT INTO Movies (Name, ReleaseDate, DateAdded, NumberInStock, GenreId) VALUES ('The Prestige', '2006-10-20', '2023-01-27', 2, 10)");
            migrationBuilder.Sql("INSERT INTO Movies (Name, ReleaseDate, DateAdded, NumberInStock, GenreId) VALUES ('The Illusionist', '2006-08-18', '2023-01-27', 4, 10)");
            migrationBuilder.Sql("INSERT INTO Movies (Name, ReleaseDate, DateAdded, NumberInStock, GenreId) VALUES ('The Secret in Their Eyes', '2009-11-27', '2023-01-27', 6, 10)");
            migrationBuilder.Sql("INSERT INTO Movies (Name, ReleaseDate, DateAdded, NumberInStock, GenreId) VALUES ('The Girl with the Dragon Tattoo', '2011-12-21', '2023-01-27', 8, 10)");
            migrationBuilder.Sql("INSERT INTO Movies (Name, ReleaseDate, DateAdded, NumberInStock, GenreId) VALUES ('The Girl Who Played with Fire', '2009-08-27', '2023-01-27', 10, 10)");
            migrationBuilder.Sql("INSERT INTO Movies (Name, ReleaseDate, DateAdded, NumberInStock, GenreId) VALUES ('The Girl Who Kicked the Hornets Nest', '2009-10-29', '2023-01-27', 12, 10)");



            migrationBuilder.Sql("INSERT INTO Customers (Name, Surname, IsSubscribedToNewsletter, MembershipTypeId, DateOfBirth) VALUES ('David', 'Miller', 0, 3, NULL)");
            migrationBuilder.Sql("INSERT INTO Customers (Name, Surname, IsSubscribedToNewsletter, MembershipTypeId, DateOfBirth) VALUES ('Richard', 'Black', 1, 4, NULL)");
            migrationBuilder.Sql("INSERT INTO Customers (Name, Surname, IsSubscribedToNewsletter, MembershipTypeId, DateOfBirth) VALUES ('Andrew', 'White', 0, 1, NULL)");
            migrationBuilder.Sql("INSERT INTO Customers (Name, Surname, IsSubscribedToNewsletter, MembershipTypeId, DateOfBirth) VALUES ('James', 'Green', 0, 1, NULL)");
            migrationBuilder.Sql("INSERT INTO Customers (Name, Surname, IsSubscribedToNewsletter, MembershipTypeId, DateOfBirth) VALUES ('Joseph', 'Anderson', 1, 2, NULL)");
            migrationBuilder.Sql("INSERT INTO Customers (Name, Surname, IsSubscribedToNewsletter, MembershipTypeId, DateOfBirth) VALUES ('Thomas', 'Hall', 0, 3, NULL)");
            migrationBuilder.Sql("INSERT INTO Customers (Name, Surname, IsSubscribedToNewsletter, MembershipTypeId, DateOfBirth) VALUES ('Charles', 'Lewis', 1, 4, NULL)");
            migrationBuilder.Sql("INSERT INTO Customers (Name, Surname, IsSubscribedToNewsletter, MembershipTypeId, DateOfBirth) VALUES ('Christopher', 'Clark', 0, 1, NULL)");
            migrationBuilder.Sql("INSERT INTO Customers (Name, Surname, IsSubscribedToNewsletter, MembershipTypeId, DateOfBirth) VALUES ('Daniel', 'Scott', 0, 1, NULL)");
            migrationBuilder.Sql("INSERT INTO Customers (Name, Surname, IsSubscribedToNewsletter, MembershipTypeId, DateOfBirth) VALUES ('Matthew', 'Young', 1, 2, NULL)");
            migrationBuilder.Sql("INSERT INTO Customers (Name, Surname, IsSubscribedToNewsletter, MembershipTypeId, DateOfBirth) VALUES ('Anthony', 'Harris', 0, 3, NULL)");
            migrationBuilder.Sql("INSERT INTO Customers (Name, Surname, IsSubscribedToNewsletter, MembershipTypeId, DateOfBirth) VALUES ('Donald', 'Moore', 1, 4, NULL)");
            migrationBuilder.Sql("INSERT INTO Customers (Name, Surname, IsSubscribedToNewsletter, MembershipTypeId, DateOfBirth) VALUES ('Mark', 'Taylor', 0, 1, NULL)");
            migrationBuilder.Sql("INSERT INTO Customers (Name, Surname, IsSubscribedToNewsletter, MembershipTypeId, DateOfBirth) VALUES ('Paul', 'Jackson', 0, 1, NULL)");
            migrationBuilder.Sql("INSERT INTO Customers (Name, Surname, IsSubscribedToNewsletter, MembershipTypeId, DateOfBirth) VALUES ('Steven', 'Lee', 1, 2, NULL)");
            migrationBuilder.Sql("INSERT INTO Customers (Name, Surname, IsSubscribedToNewsletter, MembershipTypeId, DateOfBirth) VALUES ('William', 'Thompson', 0, 3, NULL)");
            migrationBuilder.Sql("INSERT INTO Customers (Name, Surname, IsSubscribedToNewsletter, MembershipTypeId, DateOfBirth) VALUES ('George', 'White', 1, 4, NULL)");
            migrationBuilder.Sql("INSERT INTO Customers (Name, Surname, IsSubscribedToNewsletter, MembershipTypeId, DateOfBirth) VALUES ('Kenneth', 'Hill', 0, 1, NULL)");
            migrationBuilder.Sql("INSERT INTO Customers (Name, Surname, IsSubscribedToNewsletter, MembershipTypeId, DateOfBirth) VALUES ('Andrew', 'Walker', 0, 1, NULL)");
            migrationBuilder.Sql("INSERT INTO Customers (Name, Surname, IsSubscribedToNewsletter, MembershipTypeId, DateOfBirth) VALUES ('Joshua', 'Adams', 1, 2, NULL)");
            migrationBuilder.Sql("INSERT INTO Customers (Name, Surname, IsSubscribedToNewsletter, MembershipTypeId, DateOfBirth) VALUES ('Edward', 'Campbell', 0, 3, NULL)");
            migrationBuilder.Sql("INSERT INTO Customers (Name, Surname, IsSubscribedToNewsletter, MembershipTypeId, DateOfBirth) VALUES ('Brian', 'Allen', 1, 4, NULL)");
            migrationBuilder.Sql("INSERT INTO Customers (Name, Surname, IsSubscribedToNewsletter, MembershipTypeId, DateOfBirth) VALUES ('Kevin', 'Martin', 0, 1, NULL)");
            migrationBuilder.Sql("INSERT INTO Customers (Name, Surname, IsSubscribedToNewsletter, MembershipTypeId, DateOfBirth) VALUES ('Ronald', 'Robinson', 0, 1, NULL)");
            migrationBuilder.Sql("INSERT INTO Customers (Name, Surname, IsSubscribedToNewsletter, MembershipTypeId, DateOfBirth) VALUES ('Timothy', 'Clark', 1, 2, NULL)");
            migrationBuilder.Sql("INSERT INTO Customers (Name, Surname, IsSubscribedToNewsletter, MembershipTypeId, DateOfBirth) VALUES ('Jason', 'Rodriguez', 0, 3, NULL)");
            migrationBuilder.Sql("INSERT INTO Customers (Name, Surname, IsSubscribedToNewsletter, MembershipTypeId, DateOfBirth) VALUES ('Jeffrey', 'Lewis', 1, 4, NULL)");
            migrationBuilder.Sql("INSERT INTO Customers (Name, Surname, IsSubscribedToNewsletter, MembershipTypeId, DateOfBirth) VALUES ('Ryan', 'Walker', 0, 1, NULL)");
            migrationBuilder.Sql("INSERT INTO Customers (Name, Surname, IsSubscribedToNewsletter, MembershipTypeId, DateOfBirth) VALUES ('Jacob', 'Hall', 0, 1, NULL)");
            migrationBuilder.Sql("INSERT INTO Customers (Name, Surname, IsSubscribedToNewsletter, MembershipTypeId, DateOfBirth) VALUES ('Gary', 'Allen', 1, 2, NULL)");
            migrationBuilder.Sql("INSERT INTO Customers (Name, Surname, IsSubscribedToNewsletter, MembershipTypeId, DateOfBirth) VALUES ('Nicholas', 'Young', 0, 3, '1999-02-02')");
            migrationBuilder.Sql("INSERT INTO Customers (Name, Surname, IsSubscribedToNewsletter, MembershipTypeId, DateOfBirth) VALUES ('Eric', 'Harris', 1, 4, '1999-02-02')");
            migrationBuilder.Sql("INSERT INTO Customers (Name, Surname, IsSubscribedToNewsletter, MembershipTypeId, DateOfBirth) VALUES ('Stephen', 'Scott', 0, 1, '1999-02-02')");
            migrationBuilder.Sql("INSERT INTO Customers (Name, Surname, IsSubscribedToNewsletter, MembershipTypeId, DateOfBirth) VALUES ('Jonathan', 'Moore', 0, 1, '1999-02-02')");
            migrationBuilder.Sql("INSERT INTO Customers (Name, Surname, IsSubscribedToNewsletter, MembershipTypeId, DateOfBirth) VALUES ('Larry', 'Clark', 1, 2, '1999-02-02')");
            migrationBuilder.Sql("INSERT INTO Customers (Name, Surname, IsSubscribedToNewsletter, MembershipTypeId, DateOfBirth) VALUES ('Justin', 'Thompson', 0, 3, '1999-02-02')");
            migrationBuilder.Sql("INSERT INTO Customers (Name, Surname, IsSubscribedToNewsletter, MembershipTypeId, DateOfBirth) VALUES ('Scott', 'Taylor', 1, 4, '1999-02-02')");
            migrationBuilder.Sql("INSERT INTO Customers (Name, Surname, IsSubscribedToNewsletter, MembershipTypeId, DateOfBirth) VALUES ('Brandon', 'Adams', 0, 1, '1999-02-02')");
            migrationBuilder.Sql("INSERT INTO Customers (Name, Surname, IsSubscribedToNewsletter, MembershipTypeId, DateOfBirth) VALUES ('Benjamin', 'Robinson', 0, 1, '1999-02-02')");
            migrationBuilder.Sql("INSERT INTO Customers (Name, Surname, IsSubscribedToNewsletter, MembershipTypeId, DateOfBirth) VALUES ('Samuel', 'Lee', 1, 2, '1999-02-02')");
            migrationBuilder.Sql("INSERT INTO Customers (Name, Surname, IsSubscribedToNewsletter, MembershipTypeId, DateOfBirth) VALUES ('Frank', 'Hill', 0, 3, '1999-02-02')");
            migrationBuilder.Sql("INSERT INTO Customers (Name, Surname, IsSubscribedToNewsletter, MembershipTypeId, DateOfBirth) VALUES ('Gregory', 'Allen', 1, 4, '1999-02-02')");
            migrationBuilder.Sql("INSERT INTO Customers (Name, Surname, IsSubscribedToNewsletter, MembershipTypeId, DateOfBirth) VALUES ('Raymond', 'Walker', 0, 1, '1999-02-02')");
            migrationBuilder.Sql("INSERT INTO Customers (Name, Surname, IsSubscribedToNewsletter, MembershipTypeId, DateOfBirth) VALUES ('Alexander', 'Allen', 0, 1, '1999-02-02')");
            migrationBuilder.Sql("INSERT INTO Customers (Name, Surname, IsSubscribedToNewsletter, MembershipTypeId, DateOfBirth) VALUES ('Patrick', 'Scott', 1, 2, '1999-02-02')");
            migrationBuilder.Sql("INSERT INTO Customers (Name, Surname, IsSubscribedToNewsletter, MembershipTypeId, DateOfBirth) VALUES ('Jack', 'Clark', 0, 3, '1999-02-02')");
            migrationBuilder.Sql("INSERT INTO Customers (Name, Surname, IsSubscribedToNewsletter, MembershipTypeId, DateOfBirth) VALUES ('Dennis', 'Thompson', 1, 4, '1999-02-02')");
            migrationBuilder.Sql("INSERT INTO Customers (Name, Surname, IsSubscribedToNewsletter, MembershipTypeId, DateOfBirth) VALUES ('Jerry', 'Adams', 0, 1, '1999-02-02')");
            migrationBuilder.Sql("INSERT INTO Customers (Name, Surname, IsSubscribedToNewsletter, MembershipTypeId, DateOfBirth) VALUES ('Dylan', 'Robinson', 0, 1, '1999-02-02')");
            migrationBuilder.Sql("INSERT INTO Customers (Name, Surname, IsSubscribedToNewsletter, MembershipTypeId, DateOfBirth) VALUES ('Henry', 'Lee', 1, 2, '1999-02-02')");
            migrationBuilder.Sql("INSERT INTO Customers (Name, Surname, IsSubscribedToNewsletter, MembershipTypeId, DateOfBirth) VALUES ('Adam', 'Hill', 0, 3, '1999-02-02')");
            migrationBuilder.Sql("INSERT INTO Customers (Name, Surname, IsSubscribedToNewsletter, MembershipTypeId, DateOfBirth) VALUES ('Jose', 'Allen', 1, 4, '1999-02-02')");
            migrationBuilder.Sql("INSERT INTO Customers (Name, Surname, IsSubscribedToNewsletter, MembershipTypeId, DateOfBirth) VALUES ('Douglas', 'Walker', 0, 1, '1999-02-02')");
            migrationBuilder.Sql("INSERT INTO Customers (Name, Surname, IsSubscribedToNewsletter, MembershipTypeId, DateOfBirth) VALUES ('Peter', 'Allen', 0, 1, '1999-02-02')");
            migrationBuilder.Sql("INSERT INTO Customers (Name, Surname, IsSubscribedToNewsletter, MembershipTypeId, DateOfBirth) VALUES ('Nathan', 'Scott', 1, 2, '1999-02-02')");
            migrationBuilder.Sql("INSERT INTO Customers (Name, Surname, IsSubscribedToNewsletter, MembershipTypeId, DateOfBirth) VALUES ('Zachary', 'Clark', 0, 3, '1999-02-02')");
            migrationBuilder.Sql("INSERT INTO Customers (Name, Surname, IsSubscribedToNewsletter, MembershipTypeId, DateOfBirth) VALUES ('Kyle', 'Thompson', 1, 4, '1999-02-02')");
            migrationBuilder.Sql("INSERT INTO Customers (Name, Surname, IsSubscribedToNewsletter, MembershipTypeId, DateOfBirth) VALUES ('Walter', 'Adams', 0, 1, '1999-02-02')");
            migrationBuilder.Sql("INSERT INTO Customers (Name, Surname, IsSubscribedToNewsletter, MembershipTypeId, DateOfBirth) VALUES ('Jeremy', 'Robinson', 0, 1, '1999-02-02')");
            migrationBuilder.Sql("INSERT INTO Customers (Name, Surname, IsSubscribedToNewsletter, MembershipTypeId, DateOfBirth) VALUES ('Ethan', 'Lee', 1, 2, '1999-02-02')");
            migrationBuilder.Sql("INSERT INTO Customers (Name, Surname, IsSubscribedToNewsletter, MembershipTypeId, DateOfBirth) VALUES ('Harold', 'Hill', 0, 3, '1999-02-02')");
            migrationBuilder.Sql("INSERT INTO Customers (Name, Surname, IsSubscribedToNewsletter, MembershipTypeId, DateOfBirth) VALUES ('Carl', 'Allen', 1, 4, '1999-02-02')");
            migrationBuilder.Sql("INSERT INTO Customers (Name, Surname, IsSubscribedToNewsletter, MembershipTypeId, DateOfBirth) VALUES ('Keith', 'Walker', 0, 1, '1999-02-02')");
            migrationBuilder.Sql("INSERT INTO Customers (Name, Surname, IsSubscribedToNewsletter, MembershipTypeId, DateOfBirth) VALUES ('Roger', 'Allen', 0, 1, '1999-02-02')");
            migrationBuilder.Sql("INSERT INTO Customers (Name, Surname, IsSubscribedToNewsletter, MembershipTypeId, DateOfBirth) VALUES ('Arthur', 'Scott', 1, 2, '1999-02-02')");
            migrationBuilder.Sql("INSERT INTO Customers (Name, Surname, IsSubscribedToNewsletter, MembershipTypeId, DateOfBirth) VALUES ('Terry', 'Clark', 0, 3, '1999-02-02')");
            migrationBuilder.Sql("INSERT INTO Customers (Name, Surname, IsSubscribedToNewsletter, MembershipTypeId, DateOfBirth) VALUES ('Lawrence', 'Thompson', 1, 4, '1999-02-02')");
            migrationBuilder.Sql("INSERT INTO Customers (Name, Surname, IsSubscribedToNewsletter, MembershipTypeId, DateOfBirth) VALUES ('Sean', 'Adams', 0, 1, '1999-02-02')");
            migrationBuilder.Sql("INSERT INTO Customers (Name, Surname, IsSubscribedToNewsletter, MembershipTypeId, DateOfBirth) VALUES ('Sean', 'Robinson', 0, 1, '1999-02-02')");
            migrationBuilder.Sql("INSERT INTO Customers (Name, Surname, IsSubscribedToNewsletter, MembershipTypeId, DateOfBirth) VALUES ('Joe', 'Lee', 1, 2, '1999-02-02')");
            migrationBuilder.Sql("INSERT INTO Customers (Name, Surname, IsSubscribedToNewsletter, MembershipTypeId, DateOfBirth) VALUES ('Albert', 'Hill', 0, 3, '1999-02-02')");
            migrationBuilder.Sql("INSERT INTO Customers (Name, Surname, IsSubscribedToNewsletter, MembershipTypeId, DateOfBirth) VALUES ('Alan', 'Allen', 1, 4, '1999-02-02')");
            migrationBuilder.Sql("INSERT INTO Customers (Name, Surname, IsSubscribedToNewsletter, MembershipTypeId, DateOfBirth) VALUES ('Austin', 'Walker', 0, 1, '1999-02-02')");
            migrationBuilder.Sql("INSERT INTO Customers (Name, Surname, IsSubscribedToNewsletter, MembershipTypeId, DateOfBirth) VALUES ('Jesse', 'Allen', 0, 1, '1999-02-02')");
            migrationBuilder.Sql("INSERT INTO Customers (Name, Surname, IsSubscribedToNewsletter, MembershipTypeId, DateOfBirth) VALUES ('Willie', 'Scott', 1, 2, '1999-02-02')");
            migrationBuilder.Sql("INSERT INTO Customers (Name, Surname, IsSubscribedToNewsletter, MembershipTypeId, DateOfBirth) VALUES ('Ralph', 'Clark', 0, 3, '1999-02-02')");
            migrationBuilder.Sql("INSERT INTO Customers (Name, Surname, IsSubscribedToNewsletter, MembershipTypeId, DateOfBirth) VALUES ('Billy', 'Thompson', 1, 4, '1999-02-02')");
            migrationBuilder.Sql("INSERT INTO Customers (Name, Surname, IsSubscribedToNewsletter, MembershipTypeId, DateOfBirth) VALUES ('Bruce', 'Adams', 0, 1, '1999-02-02')");
            migrationBuilder.Sql("INSERT INTO Customers (Name, Surname, IsSubscribedToNewsletter, MembershipTypeId, DateOfBirth) VALUES ('Gerald', 'Robinson', 0, 1, '1999-02-02')");
            migrationBuilder.Sql("INSERT INTO Customers (Name, Surname, IsSubscribedToNewsletter, MembershipTypeId, DateOfBirth) VALUES ('Johnny', 'Lee', 1, 2, '1999-02-02')");
            migrationBuilder.Sql("INSERT INTO Customers (Name, Surname, IsSubscribedToNewsletter, MembershipTypeId, DateOfBirth) VALUES ('Wayne', 'Hill', 0, 3, '1999-02-02')");
            migrationBuilder.Sql("INSERT INTO Customers (Name, Surname, IsSubscribedToNewsletter, MembershipTypeId, DateOfBirth) VALUES ('Louis', 'Allen', 1, 4, '1999-02-02')");
            migrationBuilder.Sql("INSERT INTO Customers (Name, Surname, IsSubscribedToNewsletter, MembershipTypeId, DateOfBirth) VALUES ('Roy', 'Walker', 0, 1, '1999-02-02')");
            migrationBuilder.Sql("INSERT INTO Customers (Name, Surname, IsSubscribedToNewsletter, MembershipTypeId, DateOfBirth) VALUES ('Eugene', 'Allen', 0, 1, '1999-02-02')");
            migrationBuilder.Sql("INSERT INTO Customers (Name, Surname, IsSubscribedToNewsletter, MembershipTypeId, DateOfBirth) VALUES ('Bryan', 'Scott', 1, 2, '1999-02-02')");
            migrationBuilder.Sql("INSERT INTO Customers (Name, Surname, IsSubscribedToNewsletter, MembershipTypeId, DateOfBirth) VALUES ('Harry', 'Clark', 0, 3, '1999-02-02')");
            migrationBuilder.Sql("INSERT INTO Customers (Name, Surname, IsSubscribedToNewsletter, MembershipTypeId, DateOfBirth) VALUES ('Randy', 'Thompson', 1, 4, '1999-02-02')");
            migrationBuilder.Sql("INSERT INTO Customers (Name, Surname, IsSubscribedToNewsletter, MembershipTypeId, DateOfBirth) VALUES ('Jordan', 'Adams', 0, 1, '1999-02-02')");
            migrationBuilder.Sql("INSERT INTO Customers (Name, Surname, IsSubscribedToNewsletter, MembershipTypeId, DateOfBirth) VALUES ('Russell', 'Robinson', 0, 1, '1999-02-02')");
            migrationBuilder.Sql("INSERT INTO Customers (Name, Surname, IsSubscribedToNewsletter, MembershipTypeId, DateOfBirth) VALUES ('Vincent', 'Lee', 1, 2, '1999-02-02')");
            migrationBuilder.Sql("INSERT INTO Customers (Name, Surname, IsSubscribedToNewsletter, MembershipTypeId, DateOfBirth) VALUES ('Philip', 'Hill', 0, 3, '1999-02-02')");
            migrationBuilder.Sql("INSERT INTO Customers (Name, Surname, IsSubscribedToNewsletter, MembershipTypeId, DateOfBirth) VALUES ('Alan', 'Allen', 1, 4, '1999-02-02')");
            migrationBuilder.Sql("INSERT INTO Customers (Name, Surname, IsSubscribedToNewsletter, MembershipTypeId, DateOfBirth) VALUES ('Bobby', 'Walker', 0, 1, '1999-02-02')");
            migrationBuilder.Sql("INSERT INTO Customers (Name, Surname, IsSubscribedToNewsletter, MembershipTypeId, DateOfBirth) VALUES ('Johnny', 'Allen', 0, 1, '1999-02-02')");
            migrationBuilder.Sql("INSERT INTO Customers (Name, Surname, IsSubscribedToNewsletter, MembershipTypeId, DateOfBirth) VALUES ('Dennis', 'Scott', 1, 2, '1999-02-02')");
            migrationBuilder.Sql("INSERT INTO Customers (Name, Surname, IsSubscribedToNewsletter, MembershipTypeId, DateOfBirth) VALUES ('Jimmy', 'Clark', 0, 3, '1999-02-02')");
            migrationBuilder.Sql("INSERT INTO Customers (Name, Surname, IsSubscribedToNewsletter, MembershipTypeId, DateOfBirth) VALUES ('Earl', 'Thompson', 1, 4, '1999-02-02')");
            migrationBuilder.Sql("INSERT INTO Customers (Name, Surname, IsSubscribedToNewsletter, MembershipTypeId, DateOfBirth) VALUES ('Krzysztof', 'Jarończyk', 0, 1, '1999-07-25')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MovieDto");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Customers",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Customers",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255);

            migrationBuilder.AlterColumn<string>(
                name: "Surname",
                table: "Customers",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");
        }
    }
}
