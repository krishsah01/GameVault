namespace GameVault.Models;

/// <summary>Summary numbers and top picks shown on the home page.</summary>
public class HomeViewModel
{
    public int GameCount { get; set; }
    public int GenreCount { get; set; }
    public int DeveloperCount { get; set; }
    public IList<Game> TopGames { get; set; } = new List<Game>();
}
