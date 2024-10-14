using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using solution.Models;

namespace solution.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }
    [HttpGet]
    public IActionResult teams()
    {
        return View();
    }
    [HttpPost]
    public IActionResult teams(string? names, int teamsize)
    {
        teammodel.makenames(names.Split("\n"));
        
        teammodel.shuffle(teamsize);
        return View("teams", teammodel.teamsplit);
    }
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
