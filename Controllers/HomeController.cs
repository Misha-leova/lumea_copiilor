using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using lumea_copiilor_1.Models;

namespace lumea_copiilor_1.Controllers;

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

    public IActionResult Home()
    {
        return View();
    }

    public IActionResult Market() {
        return View();
    }

    public IActionResult News()
    {
        return View();
    }

    public IActionResult Promotions() {
        return View();

    }

    public IActionResult Contact() {
        return View();
    }

    public IActionResult User()
    {
        return View();
    }
    public IActionResult Cart()
    {
        return View();
    }


    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
