using GameVault.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GameVault.Controllers;

public class DevelopersController : Controller
{
    private readonly GameVaultContext _context;

    public DevelopersController(GameVaultContext context)
    {
        _context = context;
    }

    // GET: /Developers
    public async Task<IActionResult> Index()
    {
        var developers = await _context.Developers
            .Include(d => d.Games)
            .OrderBy(d => d.Name)
            .ToListAsync();

        return View(developers);
    }
}
