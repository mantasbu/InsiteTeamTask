# FGB Insite Team Task

One of our clients requested us to build a small UI that displays a list of members (season pass
holders) and one-time game tickets that accessed the stadium given a season and a game, or a
product code.

## Exercise 1
We have already made a .NET Core project to get and return the data. However, it has not been built
correctly. The action in the AttendanceController currently only returns data for one game, and the
data that is returned by the DataRepository is not limited at all.

The task will require you to refactor or rewrite the app. The implementation requirements are:

- Apply an appropriate design pattern to get, manipulate and return the data.
- Re-implement the GetAttendanceListFor method as it does not return correct data.
- Provide a way to get the attendance list both by season and a game, and by a product code.

## Exercise 2
Create a simple front-end application using Angular 2+ that consumes the API and displays a list of
members/ticket barcodes for either a season and game, or a product. The season and game combination
should be selected using dropdowns. The product should be selected using a dropdown as well.

## Additional considerations
If you'd like to show off your skills, there are a number of things the application could use to make it more complete:

- API security - currently anyone can access the API. This vulnerability needs to be addressed.
- Unit testing
- Front-end styling

## Assessment
What we are looking for is code quality. That translates to project structure, clean coding practices, commenting, SOLID
principles' application, and testing as applicable. We leave the details to you :)

## Submission
Create a fork of this repository. Branch off the master branch, and when you are done, create a pull request to merge the new branch in your fork into the master branch to submit your exercise. The branch should be named after your name.
