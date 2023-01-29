# VioRentals-FilmsPlatform

A movie rental application designed to help you efficiently store and manage a large amount of data on your computer. The program includes features such as tracking user activity, movie availability, and other tasks. It also provides functionalities such as CRUD operations for movies and customers, a search bar, advanced pagination, the ability to rent movies, and security for accessing administration tools.

Features
--------

*   CRUD operations for movies and customers
*   Search bar for movies and customers
*   Advanced pagination with the ability to change the displayed number of records and jump to any page
*   Ability to rent movies to users (with a limit of 1 movie per user and max 5 movies at the same time)
*   Secure access to administration features with login and registration options
*   API for customers and movies
*   Data Transfer Objects (DTOs) for movies and customers
*   Bootstrap template
*   xUnit tests

Extensions
----------

*   AutoMapper
*   Microsoft.EntityFrameworkCore extensions
*   Jquery
*   SwashBuckle (Swagger)
*   xUnit
*   Moq

![VioRentals Screenshot](https://github.com/KrzysztofJaronczyk/VioRentals-FilmsPlatform/blob/master/wwwroot/css/VioRentals.jpeg?raw=true)

How to use
----------

1.  Clone the repository

```
git clone https://github.com/KrzysztofJaronczyk/VioRentals-FilmsPlatform.git
```

2.  Navigate to the project directory

```
cd VioRentals
```

3.  Restore the packages

```
dotnet restore
```

4.  Run the project

```
dotnet run
```

5.  Open your browser and go to `http://localhost:5000/`

Enjoy using VioRentals!
