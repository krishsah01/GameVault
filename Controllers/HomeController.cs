using System.Diagnostics;
using GameVault.Data;
using GameVault.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GameVault.Controllers;

public class HomeController : Controller
{
    private readonly GameVaultContext _context;

    public HomeController(GameVaultContext context)
    {
        _context = context;
    }

    public async Task<IActionResult> Index()
    {
        var model = new HomeViewModel
        {
            GameCount = await _context.Games.CountAsync(),
            GenreCount = await _context.Genres.CountAsync(),
            DeveloperCount = await _context.Developers.CountAsync(),
            TopGames = await _context.Games
                .Include(g => g.Genre)
                .OrderByDescending(g => g.MyRating)
                .ThenBy(g => g.Title)
                .Take(3)
                .ToListAsync()
        };

        return View(model);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
