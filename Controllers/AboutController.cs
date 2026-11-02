using Microsoft.AspNetCore.Mvc;

namespace GameVault.Controllers;

public class AboutController : Controller
{
    // GET: /About/Hobby  - about the hobby (video games)
    public IActionResult Hobby()
    {
        return View();
    }

    // GET: /About/Me  - about the site's author
    public IActionResult Me()
    {
        return View();
    }
}
