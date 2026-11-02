using Microsoft.AspNetCore.Mvc.Rendering;

namespace GameVault.Models;

/// <summary>Data for the Games/Index table: the rows plus the current search/filter state.</summary>
public class GameListViewModel
{
    public IList<Game> Games { get; set; } = new List<Game>();

    public SelectList? Genres { get; set; }

    public string? Search { get; set; }

    public int? GenreId { get; set; }
}
