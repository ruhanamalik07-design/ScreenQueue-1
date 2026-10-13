# Movie Watchlist

## Project Description

Movie Watchlist is an ASP.NET Core MVC web app (built in C#) for COMP 2084 - Server Side Scripting at Georgian College.

The aim of the app is to allow users to keep a list of films they'd like to watch and to rate the films. Users will be able to maintain a list of films, keep details of the films and rate them in order to track their film watching.

## Technologies Used

- C#
- ASP.NET Core MVC
- SQL Server
- Entity Framework Core
- HTML and CSS
- Git and GitHub
- ASP.NET Core Identity (for authentication)

## Main Features

- Maintain a film watchlist.
- Keep movie details in a database.
- Record and manage film ratings.
- Use related database models to organise the movie information.
- Support user authentication via ASP.NET Core Identity.

*Note: Features will be implemented as the project progresses.*

## Database Design

The app will use the relevant model classes to store the movie data and ratings.

- Movie: stores movie details such as title, genre, year of release and description.
- Review: Stores the rating information for a movie (the rating and the review).

A one-to-many relationship will link the Movie and Review models so that one movie can have many reviews.

## Purpose of the Project

This is the project to demonstrate the development of an ASP.NET Core MVC web app in C#, with the use of database relationships and version control via GitHub. It will form the basis of Assignments 2, 3 and 4 in COMP 2084.

## Author

Student Name: Ruhana Malik

Course: COMP 2084 – Server-Side Scripting

College: Georgian College