# Trifork Programming Exercise

What you see in this repository is a standard .NET solution with a single .NET 7 project.

The project is a simple ASP.NET Web API that exposes a single endpoint that returns a list of Stations.

EF Core has been set up and configured with and SQLite database. The database is seeded with a few stations.

## The Task

The task is to implement the `GetStations` method in the `StationsController` class. The method should return a list of stations from the database.

The database's Station model's StationUicOrPart field unfortunately has inconsistent formatting. It can be either a complete 7-digit StationUic with the first four digits always being `8600`, or a partial 3-digit StationUic representing the last three digits of the complete code. An example could be a full StationUic like `8600123` with its partial equivalent `123`.

## Requirements

- The `GetStations` endpoint should return a list of stations with the StationUicPart.
  - This means that if the StationUicOrPart is a full StationUic, the StationUicPart should consist of the last three digits of the StationUic. If the StationUicOrPart is a partial StationUic, the StationUicPart should be the same as the StationUicOrPart.
  - For example if the StationUicOrPart is `8600123`, the StationUicPart should be `123`. If the StationUicOrPart is `123`, the StationUicPart should be `123`.
- The API should be properly decoupled.
- The API should be properly unit tested.
- Implement the mapping logic in such a way that it is reusable and easy to add new mapping rules in the future.
- Make a pull request to this repository with your solution.

## The rules

- You are not allowed to change the StationUicOrPart field in the database.
- You are not allowed to change the Station model.
- You are not allowed to change the StationDto model.
- You are not allowed to modify the seeded stations in the database, though you are allowed to add more.
- You are allowed to create new classes and interfaces.
- You are allowed to change the StationsController class.
- You are allowed to modify `Program.cs`.
