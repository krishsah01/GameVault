using GameVault.Models;

namespace GameVault.Data;

/// <summary>Test data for the hobby database. Used by HasData() so migrations create and fill the tables.</summary>
public static class SeedData
{
    public static readonly Genre[] Genres =
    {
        new Genre { Id = 1, Name = "Action-Adventure" },
        new Genre { Id = 2, Name = "RPG" },
        new Genre { Id = 3, Name = "Shooter" },
        new Genre { Id = 4, Name = "Sandbox" },
        new Genre { Id = 5, Name = "Strategy" },
        new Genre { Id = 6, Name = "Platformer" },
        new Genre { Id = 7, Name = "Puzzle" },
    };

    public static readonly Developer[] Developers =
    {
        new Developer { Id = 1, Name = "Nintendo", Country = "Japan", FoundedYear = 1889 },
        new Developer { Id = 2, Name = "Mojang Studios", Country = "Sweden", FoundedYear = 2009 },
        new Developer { Id = 3, Name = "CD Projekt Red", Country = "Poland", FoundedYear = 2002 },
        new Developer { Id = 4, Name = "FromSoftware", Country = "Japan", FoundedYear = 1986 },
        new Developer { Id = 5, Name = "Valve", Country = "United States", FoundedYear = 1996 },
        new Developer { Id = 6, Name = "Rockstar Games", Country = "United States", FoundedYear = 1998 },
        new Developer { Id = 7, Name = "Riot Games", Country = "United States", FoundedYear = 2006 },
        new Developer { Id = 8, Name = "Bethesda Game Studios", Country = "United States", FoundedYear = 2001 },
    };

    public static readonly Game[] Games =
    {
        new Game { Id = 1, Title = "The Legend of Zelda: Breath of the Wild", ReleaseYear = 2017, Platform = "Nintendo Switch", MyRating = 10, GenreId = 1, DeveloperId = 1, Description = "Open-air adventure where you can climb almost anything and tackle the world in nearly any order." },
        new Game { Id = 2, Title = "Minecraft", ReleaseYear = 2011, Platform = "PC", MyRating = 9, GenreId = 4, DeveloperId = 2, Description = "A sandbox of endless creativity: mine, craft, build and survive in a procedurally generated world." },
        new Game { Id = 3, Title = "The Witcher 3: Wild Hunt", ReleaseYear = 2015, Platform = "PC", MyRating = 10, GenreId = 2, DeveloperId = 3, Description = "Story-driven open-world RPG following monster hunter Geralt of Rivia." },
        new Game { Id = 4, Title = "Elden Ring", ReleaseYear = 2022, Platform = "PC", MyRating = 9, GenreId = 2, DeveloperId = 4, Description = "Challenging open-world action RPG set in the Lands Between." },
        new Game { Id = 5, Title = "Portal 2", ReleaseYear = 2011, Platform = "PC", MyRating = 10, GenreId = 7, DeveloperId = 5, Description = "First-person puzzle game built around the portal gun, with sharp humor and clever level design." },
        new Game { Id = 6, Title = "Counter-Strike 2", ReleaseYear = 2023, Platform = "PC", MyRating = 8, GenreId = 3, DeveloperId = 5, Description = "Competitive tactical shooter built on teamwork, economy and precise aim." },
        new Game { Id = 7, Title = "Red Dead Redemption 2", ReleaseYear = 2018, Platform = "PC", MyRating = 9, GenreId = 1, DeveloperId = 6, Description = "Western epic with a richly detailed open world and a cinematic story." },
        new Game { Id = 8, Title = "Half-Life: Alyx", ReleaseYear = 2020, Platform = "PC (VR)", MyRating = 9, GenreId = 3, DeveloperId = 5, Description = "Virtual-reality return to the Half-Life universe, praised for immersive interaction." },
        new Game { Id = 9, Title = "Super Mario Odyssey", ReleaseYear = 2017, Platform = "Nintendo Switch", MyRating = 9, GenreId = 6, DeveloperId = 1, Description = "Globe-trotting 3D platformer featuring Mario and his sentient hat, Cappy." },
        new Game { Id = 10, Title = "The Elder Scrolls V: Skyrim", ReleaseYear = 2011, Platform = "PC", MyRating = 9, GenreId = 2, DeveloperId = 8, Description = "Open-world fantasy RPG with dragons, deep mod support and near-endless exploration." },
        new Game { Id = 11, Title = "Grand Theft Auto V", ReleaseYear = 2013, Platform = "PC", MyRating = 8, GenreId = 1, DeveloperId = 6, Description = "Open-world crime game following three protagonists in the city of Los Santos." },
        new Game { Id = 12, Title = "League of Legends", ReleaseYear = 2009, Platform = "PC", MyRating = 7, GenreId = 5, DeveloperId = 7, Description = "Team-based MOBA where two teams of five battle to destroy the opposing Nexus." },
    };
}
