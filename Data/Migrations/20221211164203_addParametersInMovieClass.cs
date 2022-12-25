using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VioRentals.Data.Migrations
{
    public partial class addParametersInMovieClass : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DateAdded",
                table: "Movies",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Genre",
                table: "Movies",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "NumberInStock",
                table: "Movies",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "ReleaseDate",
                table: "Movies",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            //add records to movies
            migrationBuilder.Sql("INSERT INTO Movies (Name, Genre, ReleaseDate, DateAdded, NumberInStock) VALUES ('Hangover', 'Comedy', '2009-06-05', '2022-11-12', 5)");
            migrationBuilder.Sql("INSERT INTO Movies (Name, Genre, ReleaseDate, DateAdded, NumberInStock) VALUES ('Terminator', 'Action', '1984-11-26','2022-11-12', 15)");
            migrationBuilder.Sql("INSERT INTO Movies (Name, Genre, ReleaseDate, DateAdded, NumberInStock) VALUES ('Die Hard', 'Action', '1988-07-15', '2022-11-12', 5)");
            migrationBuilder.Sql("INSERT INTO Movies (Name, Genre, ReleaseDate, DateAdded, NumberInStock) VALUES ('Toy Story', 'Family', '1995-11-22', '2022-11-12', 3)");
            migrationBuilder.Sql("INSERT INTO Movies (Name, Genre, ReleaseDate, DateAdded, NumberInStock) VALUES ('Titanic', 'Romance', '1997-12-19', '2022-11-12', 2)");
            migrationBuilder.Sql("INSERT INTO Movies (Name, Genre, ReleaseDate, DateAdded, NumberInStock) VALUES ('The Avengers', 'Action', '2012-04-25', '2022-11-12', 10)");
            migrationBuilder.Sql("INSERT INTO Movies (Name, Genre, ReleaseDate, DateAdded, NumberInStock) VALUES ('The Dark Knight', 'Action', '2008-07-18', '2022-11-12', 5)");
            migrationBuilder.Sql("INSERT INTO Movies (Name, Genre, ReleaseDate, DateAdded, NumberInStock) VALUES ('The Hangover Part II', 'Comedy', '2011-05-26', '2022-11-12', 5)");
            migrationBuilder.Sql("INSERT INTO Movies (Name, Genre, ReleaseDate, DateAdded, NumberInStock) VALUES ('The Lion King', 'Family', '1994-06-23', '2022-11-12', 3)");
            migrationBuilder.Sql("INSERT INTO Movies (Name, Genre, ReleaseDate, DateAdded, NumberInStock) VALUES ('The Lord of the Rings: The Fellowship of the Ring', 'Adventure', '2001-12-19', '2022-11-12', 5)");
            migrationBuilder.Sql("INSERT INTO Movies (Name, Genre, ReleaseDate, DateAdded, NumberInStock) VALUES ('The Lord of the Rings: The Return of the King', 'Adventure', '2003-12-17', '2022-11-12', 5)");
            migrationBuilder.Sql("INSERT INTO Movies (Name, Genre, ReleaseDate, DateAdded, NumberInStock) VALUES ('The Lord of the Rings: The Two Towers', 'Adventure', '2002-12-18', '2022-11-12', 5)");
            migrationBuilder.Sql("INSERT INTO Movies (Name, Genre, ReleaseDate, DateAdded, NumberInStock) VALUES ('The Matrix', 'Action', '1999-03-31', '2022-11-12', 5)");
            migrationBuilder.Sql("INSERT INTO Movies (Name, Genre, ReleaseDate, DateAdded, NumberInStock) VALUES ('The Matrix Reloaded', 'Action', '2003-05-15', '2022-11-12', 5)");
            migrationBuilder.Sql("INSERT INTO Movies (Name, Genre, ReleaseDate, DateAdded, NumberInStock) VALUES ('The Matrix Revolutions', 'Action', '2003-11-05', '2022-11-12', 5)");
            migrationBuilder.Sql("INSERT INTO Movies (Name, Genre, ReleaseDate, DateAdded, NumberInStock) VALUES ('The Shawshank Redemption', 'Drama', '1994-09-23', '2022-11-12', 5)");
            migrationBuilder.Sql("INSERT INTO Movies (Name, Genre, ReleaseDate, DateAdded, NumberInStock) VALUES ('The Sixth Sense', 'Drama', '1999-08-06', '2022-11-12', 5)");
            migrationBuilder.Sql("INSERT INTO Movies (Name, Genre, ReleaseDate, DateAdded, NumberInStock) VALUES ('The Wolf of Wall Street', 'Comedy', '2013-12-25', '2022-11-12', 5)");
            migrationBuilder.Sql("INSERT INTO Movies (Name, Genre, ReleaseDate, DateAdded, NumberInStock) VALUES ('Toy Story 2', 'Family', '1999-11-24', '2022-11-12', 3)");
            migrationBuilder.Sql("INSERT INTO Movies (Name, Genre, ReleaseDate, DateAdded, NumberInStock) VALUES ('Toy Story 3', 'Family', '2010-06-18', '2022-11-12', 3)");
            migrationBuilder.Sql("INSERT INTO Movies (Name, Genre, ReleaseDate, DateAdded, NumberInStock) VALUES ('Up', 'Family', '2009-05-29', '2022-11-12', 3)");
            migrationBuilder.Sql("INSERT INTO Movies (Name, Genre, ReleaseDate, DateAdded, NumberInStock) VALUES ('V for Vendetta', 'Action', '2005-03-17', '2022-11-12', 5)");
            migrationBuilder.Sql("INSERT INTO Movies (Name, Genre, ReleaseDate, DateAdded, NumberInStock) VALUES ('Zootopia', 'Family', '2016-03-04', '2022-11-12', 3)");
            migrationBuilder.Sql("INSERT INTO Movies (Name, Genre, ReleaseDate, DateAdded, NumberInStock) VALUES ('The Godfather', 'Drama', '1972-03-24', '2022-11-12', 5)");
            migrationBuilder.Sql("INSERT INTO Movies (Name, Genre, ReleaseDate, DateAdded, NumberInStock) VALUES ('The Godfather: Part II', 'Drama', '1974-12-20', '2022-11-12', 5)");
            migrationBuilder.Sql("INSERT INTO Movies (Name, Genre, ReleaseDate, DateAdded, NumberInStock) VALUES ('The Godfather: Part III', 'Drama', '1990-12-20', '2022-11-12', 5)");
            migrationBuilder.Sql("INSERT INTO Movies (Name, Genre, ReleaseDate, DateAdded, NumberInStock) VALUES ('The Green Mile', 'Drama', '1999-12-10', '2022-11-12', 5)");
            migrationBuilder.Sql("INSERT INTO Movies (Name, Genre, ReleaseDate, DateAdded, NumberInStock) VALUES ('The Hunger Games', 'Adventure', '2012-03-23', '2022-11-12', 5)");
            migrationBuilder.Sql("INSERT INTO Movies (Name, Genre, ReleaseDate, DateAdded, NumberInStock) VALUES ('The Hunger Games: Catching Fire', 'Adventure', '2013-11-22', '2022-11-12', 5)");
            migrationBuilder.Sql("INSERT INTO Movies (Name, Genre, ReleaseDate, DateAdded, NumberInStock) VALUES ('The Hunger Games: Mockingjay - Part 1', 'Adventure', '2014-11-21', '2022-11-12', 5)");
            migrationBuilder.Sql("INSERT INTO Movies (Name, Genre, ReleaseDate, DateAdded, NumberInStock) VALUES ('The Hunger Games: Mockingjay - Part 2', 'Adventure', '2015-11-20', '2022-11-12', 5)");
            migrationBuilder.Sql("INSERT INTO Movies (Name, Genre, ReleaseDate, DateAdded, NumberInStock) VALUES ('The Incredibles', 'Family', '2004-11-05', '2022-11-12', 3)");
            //add records to custommers
            migrationBuilder.Sql("INSERT INTO Customers (Name, IsSubscribedToNewsletter, MembershipTypeId, DateOfBirth) VALUES ('John Smith', 0, 1, '1990-01-01')");
            migrationBuilder.Sql("INSERT INTO Customers (Name, IsSubscribedToNewsletter, MembershipTypeId, DateOfBirth) VALUES ('Mary Williams', 1, 2, '1999-01-01')");
            migrationBuilder.Sql("INSERT INTO Customers (Name, IsSubscribedToNewsletter, MembershipTypeId, DateOfBirth) VALUES ('Robert Johnson', 0, 3, '2001-01-01')");
            migrationBuilder.Sql("INSERT INTO Customers (Name, IsSubscribedToNewsletter, MembershipTypeId, DateOfBirth) VALUES ('Patricia Jones', 1, 4, '2005-01-01')");
            migrationBuilder.Sql("INSERT INTO Customers (Name, IsSubscribedToNewsletter, MembershipTypeId, DateOfBirth) VALUES ('Michael Brown', 0, 1, NULL)");
            migrationBuilder.Sql("INSERT INTO Customers (Name, IsSubscribedToNewsletter, MembershipTypeId, DateOfBirth) VALUES ('Linda Davis', 1, 2, NULL)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateAdded",
                table: "Movies");

            migrationBuilder.DropColumn(
                name: "Genre",
                table: "Movies");

            migrationBuilder.DropColumn(
                name: "NumberInStock",
                table: "Movies");

            migrationBuilder.DropColumn(
                name: "ReleaseDate",
                table: "Movies");
        }
    }
}
