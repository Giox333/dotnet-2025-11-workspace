using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers;

public class ContactController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public ContactController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        var jsonData = DataRetriver.CreaJson("mario", "rossi");
        ViewBag.JsonData = jsonData; // Memorizziamo il JSON in ViewBag
        var myValue = 1;
        ViewBag.JsonData = 1;
        return View();
    }

   

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
