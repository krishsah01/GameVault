# GameVault

An ASP.NET Core MVC website that documents one of my favorite hobbies: **video games**.
Built for the Final Project (Check-in 3).

## Pages
| Page | Route | Controller |
|------|-------|-----------|
| Home (stats + top picks) | `/` | `HomeController` |
| My Games (database table with search/filter) | `/Games` | `GamesController` |
| Game details | `/Games/Details/{id}` | `GamesController` |
| Genres | `/Genres` | `GenresController` |
| Studios | `/Developers` | `DevelopersController` |
| About the hobby | `/About/Hobby` | `AboutController` |
| About me | `/About/Me` | `AboutController` |

## Tech
- ASP.NET Core MVC (.NET 8), Razor views, shared `_Layout.cshtml`, `_ViewStart`, `_ViewImports`
- Entity Framework Core 8 + SQL Server LocalDB (`Migrations/` folder, seed data in `Data/SeedData.cs`)
- `GameVaultContext` registered in `Program.cs` and injected into controllers (DI / IoC)
- Connection string in `appsettings.json`
- Bootstrap 5 + jQuery in `wwwroot/lib`

## Run it
Requires the .NET 8 SDK and SQL Server LocalDB (installed with Visual Studio).

```bash
dotnet restore
dotnet ef database update   # creates GameVaultDb in (localdb)\MSSQLLocalDB and inserts the seed data
dotnet run
```

In the Development environment the app also applies migrations automatically on startup.

## Git workflow
Work was done on feature branches (`feature/database-ef`, `feature/games-pages`, `feature/about-pages`) and merged into `main`.
