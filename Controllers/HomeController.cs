using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TP_Escape.Models;

namespace TP_Escape.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index(string mensajePresentacion)
    {
        ViewBag.mensajePresentacion = mensajePresentacion;
        return View("Index");
    }

    public IActionResult Tutorial(string explicacion)
    {
        ViewBag.explicacion = explicacion;
        return View("Tutorial");
    }

    public IActionResult Comenzar(int estadoJuego)
    {
        return View("Habitacion" + estadoJuego);
    }

     public IActionResult Habitacion1(int sala, string clave)
    {
        return View();
    }

    public IActionResult Habitacion2(int sala, string clave)
    {
        return View();
    }

    public IActionResult Habitacion3(int sala, string clave)
    {
        return View();
    }
    public IActionResult Habitacion4(int sala, string clave)
    {
        return View();
    }


    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
