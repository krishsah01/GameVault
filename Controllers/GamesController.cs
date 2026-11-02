using GameVault.Data;
using GameVault.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace GameVault.Controllers;

public class GamesController : Controller
{
    private readonly GameVaultContext _context;

    // GameVaultContext is supplied by the DI container (registered in Program.cs)
    public GamesController(GameVaultContext context)
    {
        _context = context;
    }

    // GET: /Games?search=zelda&genreId=2
    public async Task<IActionResult> Index(string? search, int? genreId)
    {
        var query = _context.Games
            .Include(g => g.Genre)
            .Include(g => g.Developer)
            .AsQueryable();

        if (!string.IsNullOrWhiteSpace(search))
        {
            query = query.Where(g => g.Title.Contains(search));
        }

        if (genreId.HasValue)
        {
            query = query.Where(g => g.GenreId == genreId.Value);
        }

        var model = new GameListViewModel
        {
            Games = await query.OrderByDescending(g => g.MyRating).ThenBy(g => g.Title).ToListAsync(),
            Genres = new SelectList(await _context.Genres.OrderBy(g => g.Name).ToListAsync(), "Id", "Name", genreId),
            Search = search,
            GenreId = genreId
        };

        return View(model);
    }

    // GET: /Games/Details/5
    public async Task<IActionResult> Details(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var game = await _context.Games
            .Include(g => g.Genre)
            .Include(g => g.Developer)
            .FirstOrDefaultAsync(g => g.Id == id);

        if (game == null)
        {
            return NotFound();
        }

        return View(game);
    }
}
