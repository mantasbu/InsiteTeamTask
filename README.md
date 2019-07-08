# FGB Insite Team Task

One of our clients requested us to build a small UI that displays a list of members (season pass
holders) and one-time game tickets that accessed the stadium given a season and a game, or a
product code.

## Exercise 1
We have already made a .NET Core project to get and return the data; however, it has not been built
correctly.

The task will require you to refactor or rewrite the app. The implementation requirements are:

- Apply an appropriate design pattern to get, manipulate and return the data.
- Re-implement the GetAttendanceListFor method as it does not return correct data.
- Provide a way to get the attendance list both by season and a game, and by a product code.
- The API is not secure: anyone can use it. This vulnerability needs to be addressed.
- Write automatic tests.

## Exercise 2
Create a simple front-end application using Angular 2+ that consumes the API and displays a list of
members/ticket barcodes per season and a game, or product. The season and game combination
should be selected using dropdowns. The product must be selected using a dropdown as well.

## Submission
Branch off the master branch, and when you are done, create a pull request to submit your exercise. The branch should be named after your name.
