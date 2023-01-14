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
            migrationBuilder.Sql("INSERT INTO Movies (Name, ReleaseDate, DateAdded, NumberInStock, GenreId) VALUES ('Avengers: Age of Ultron', '2015-05-01', '2015-06-05', 5, 1)");
            migrationBuilder.Sql("INSERT INTO Movies (Name, ReleaseDate, DateAdded, NumberInStock, GenreId) VALUES ('Avatar', '2009-12-18', '2015-06-05', 5, 2)");
            migrationBuilder.Sql("INSERT INTO Movies (Name, ReleaseDate, DateAdded, NumberInStock, GenreId) VALUES ('Aliens', '1986-07-18', '2015-06-05', 5, 2)");
            migrationBuilder.Sql("INSERT INTO Movies (Name, ReleaseDate, DateAdded, NumberInStock, GenreId) VALUES ('Alien', '1979-05-25', '2015-06-05', 5, 2)");
            migrationBuilder.Sql("INSERT INTO Movies (Name, ReleaseDate, DateAdded, NumberInStock, GenreId) VALUES ('Alien 3', '1992-05-22', '2015-06-05', 5, 2)");
            migrationBuilder.Sql("INSERT INTO Movies (Name, ReleaseDate, DateAdded, NumberInStock, GenreId) VALUES ('Alien: Resurrection', '1997-09-07', '2015-06-05', 5, 2)");
            migrationBuilder.Sql("INSERT INTO Movies (Name, ReleaseDate, DateAdded, NumberInStock, GenreId) VALUES ('Terminator 2: Judgment Day', '1991-07-03', '2015-06-05', 5, 2)");
            migrationBuilder.Sql("INSERT INTO Movies (Name, ReleaseDate, DateAdded, NumberInStock, GenreId) VALUES ('Terminator 3: Rise of the Machines', '2003-07-02', '2015-06-05', 5, 2)");
            migrationBuilder.Sql("INSERT INTO Movies (Name, ReleaseDate, DateAdded, NumberInStock, GenreId) VALUES ('Terminator Salvation', '2009-05-21', '2015-06-05', 5, 2)");
            migrationBuilder.Sql("INSERT INTO Movies (Name, ReleaseDate, DateAdded, NumberInStock, GenreId) VALUES ('Terminator Genisys', '2015-07-01', '2015-06-05', 5, 2)");
            migrationBuilder.Sql("INSERT INTO Movies (Name, ReleaseDate, DateAdded, NumberInStock, GenreId) VALUES ('Alien vs. Predator', '2004-08-06', '2015-06-05', 5, 2)");
            migrationBuilder.Sql("INSERT INTO Movies (Name, ReleaseDate, DateAdded, NumberInStock, GenreId) VALUES ('Alien vs. Predator: Requiem', '2007-08-09', '2015-06-05', 5, 2)");
            migrationBuilder.Sql("INSERT INTO Movies (Name, ReleaseDate, DateAdded, NumberInStock, GenreId) VALUES ('Predator', '1987-06-12', '2015-06-05', 5, 2)");
            migrationBuilder.Sql("INSERT INTO Movies (Name, ReleaseDate, DateAdded, NumberInStock, GenreId) VALUES ('Predator 2', '1990-07-12', '2015-06-05', 5, 2)");
            migrationBuilder.Sql("INSERT INTO Movies (Name, ReleaseDate, DateAdded, NumberInStock, GenreId) VALUES ('Predators', '2010-07-07', '2015-06-05', 5, 2)");
            migrationBuilder.Sql("INSERT INTO Movies (Name, ReleaseDate, DateAdded, NumberInStock, GenreId) VALUES ('Avengers: Infinity War', '2018-04-27', '2018-04-27', 5, 1)");
            migrationBuilder.Sql("INSERT INTO Movies (Name, ReleaseDate, DateAdded, NumberInStock, GenreId) VALUES ('Avengers: Endgame', '2019-04-26', '2019-04-26', 5, 1)");
            migrationBuilder.Sql("INSERT INTO Movies (Name, ReleaseDate, DateAdded, NumberInStock, GenreId) VALUES ('Pirates of the Caribbean: The Curse of the Black Pearl', '2003-07-09', '2015-06-05', 5, 3)");
            migrationBuilder.Sql("INSERT INTO Movies (Name, ReleaseDate, DateAdded, NumberInStock, GenreId) VALUES ('Once Upon a Time in Hollywood', '2019-07-26', '2019-07-26', 5, 6)");
            migrationBuilder.Sql("INSERT INTO Movies (Name, ReleaseDate, DateAdded, NumberInStock, GenreId) VALUES ('E.T. the Extra-Terrestrial', '1982-06-11', '2015-06-05', 5, 2)");
            migrationBuilder.Sql("INSERT INTO Movies (Name, ReleaseDate, DateAdded, NumberInStock, GenreId) VALUES ('Indiana Jones and the Last Crusade', '1989-05-24', '2015-06-05', 5, 4)");
            migrationBuilder.Sql("INSERT INTO Movies (Name, ReleaseDate, DateAdded, NumberInStock, GenreId) VALUES ('Indiana Jones and the Temple of Doom', '1984-05-23', '2015-06-05', 5, 4)");
            migrationBuilder.Sql("INSERT INTO Movies (Name, ReleaseDate, DateAdded, NumberInStock, GenreId) VALUES ('Indiana Jones and the Kingdom of the Crystal Skull', '2008-05-22', '2015-06-05', 5, 4)");
            migrationBuilder.Sql("INSERT INTO Movies (Name, ReleaseDate, DateAdded, NumberInStock, GenreId) VALUES ('Indiana Jones and the Raiders of the Lost Ark', '1981-06-12', '2015-06-05', 5, 4)");
            migrationBuilder.Sql("INSERT INTO Movies (Name, ReleaseDate, DateAdded, NumberInStock, GenreId) VALUES ('Zoolander', '2001-02-16', '2015-06-05', 5, 5)");
            migrationBuilder.Sql("INSERT INTO Movies (Name, ReleaseDate, DateAdded, NumberInStock, GenreId) VALUES ('Zoolander 2', '2016-02-12', '2016-02-12', 5, 5)");
            migrationBuilder.Sql("INSERT INTO Movies (Name, ReleaseDate, DateAdded, NumberInStock, GenreId) VALUES ('NASA: A Human Adventure', '2015-04-16', '2015-04-16', 5, 7)");
            migrationBuilder.Sql("INSERT INTO Movies (Name, ReleaseDate, DateAdded, NumberInStock, GenreId) VALUES ('The Martian', '2015-10-02', '2015-10-02', 5, 7)");
            migrationBuilder.Sql("INSERT INTO Movies (Name, ReleaseDate, DateAdded, NumberInStock, GenreId) VALUES ('Apollo 13', '1995-06-30', '2015-06-05', 5, 7)");
            migrationBuilder.Sql("INSERT INTO Movies (Name, ReleaseDate, DateAdded, NumberInStock, GenreId) VALUES ('The Right Stuff', '1983-12-17', '2015-06-05', 5, 7)");
            migrationBuilder.Sql("INSERT INTO Movies (Name, ReleaseDate, DateAdded, NumberInStock, GenreId) VALUES ('Wszechświat', '2014-10-10', '2014-10-10', 5, 7)");
            migrationBuilder.Sql("INSERT INTO Movies (Name, ReleaseDate, DateAdded, NumberInStock, GenreId) VALUES ('The Big Bang Theory', '2007-09-24', '2015-06-05', 5, 8)");
            migrationBuilder.Sql("INSERT INTO Movies (Name, ReleaseDate, DateAdded, NumberInStock, GenreId) VALUES ('Interstellar', '2014-11-07', '2015-06-05', 5, 7)");
            migrationBuilder.Sql("INSERT INTO Movies (Name, ReleaseDate, DateAdded, NumberInStock, GenreId) VALUES ('The Theory of Everything', '2014-11-26', '2015-06-05', 5, 7)");
            migrationBuilder.Sql("INSERT INTO Movies (Name, ReleaseDate, DateAdded, NumberInStock, GenreId) VALUES ('The Imitation Game', '2014-11-14', '2015-06-05', 5, 7)");
            migrationBuilder.Sql("INSERT INTO Movies (Name, ReleaseDate, DateAdded, NumberInStock, GenreId) VALUES ('The Social Network', '2010-10-01', '2015-06-05', 5, 7)");
            migrationBuilder.Sql("INSERT INTO Movies (Name, ReleaseDate, DateAdded, NumberInStock, GenreId) VALUES ('The Wolf of Wall Street', '2013-12-25', '2015-06-05', 5, 7)");
            migrationBuilder.Sql("INSERT INTO Movies (Name, ReleaseDate, DateAdded, NumberInStock, GenreId) VALUES ('The Hateful Eight', '2015-12-25', '2015-12-25', 5, 6)");
            migrationBuilder.Sql("INSERT INTO Movies (Name, ReleaseDate, DateAdded, NumberInStock, GenreId) VALUES ('The Revenant', '2015-12-25', '2015-12-25', 5, 6)");
            migrationBuilder.Sql("INSERT INTO Movies (Name, ReleaseDate, DateAdded, NumberInStock, GenreId) VALUES ('The Grand Budapest Hotel', '2014-02-28', '2015-06-05', 5, 6)");
            migrationBuilder.Sql("INSERT INTO Movies (Name, ReleaseDate, DateAdded, NumberInStock, GenreId) VALUES ('Life of Pi', '2012-11-21', '2015-06-05', 5, 6)");
            migrationBuilder.Sql("INSERT INTO Movies (Name, ReleaseDate, DateAdded, NumberInStock, GenreId) VALUES ('The Hobbit: The Battle of the Five Armies', '2014-12-17', '2015-06-05', 5, 6)");
            migrationBuilder.Sql("INSERT INTO Movies (Name, ReleaseDate, DateAdded, NumberInStock, GenreId) VALUES ('The Hobbit: The Desolation of Smaug', '2013-12-13', '2015-06-05', 5, 6)");
            migrationBuilder.Sql("INSERT INTO Movies (Name, ReleaseDate, DateAdded, NumberInStock, GenreId) VALUES ('The Hobbit: An Unexpected Journey', '2012-12-14', '2015-06-05', 5, 6)");
            migrationBuilder.Sql("INSERT INTO Movies (Name, ReleaseDate, DateAdded, NumberInStock, GenreId) VALUES ('13 Hours: The Secret Soldiers of Benghazi', '2016-01-15', '2016-01-15', 5, 6)");
            migrationBuilder.Sql("INSERT INTO Movies (Name, ReleaseDate, DateAdded, NumberInStock, GenreId) VALUES ('whiplash', '2014-10-10', '2014-10-10', 5, 6)");



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
