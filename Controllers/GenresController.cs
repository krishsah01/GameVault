using GameVault.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GameVault.Controllers;

public class GenresController : Controller
{
    private readonly GameVaultContext _context;

    public GenresController(GameVaultContext context)
    {
        _context = context;
    }

    // GET: /Genres
    public async Task<IActionResult> Index()
    {
        var genres = await _context.Genres
            .Include(g => g.Games)
            .OrderBy(g => g.Name)
            .ToListAsync();

        return View(genres);
    }
}
