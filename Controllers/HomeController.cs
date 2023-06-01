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

    public IActionResult Index()
    {
        ViewBag.mensajePresentacion = "Aqui te presentaremos la carrera de 4 distintos jugadores europeos y tendras que adivinar de quien se trata";
        return View("Index");
    }

    public IActionResult Tutorial()
    {
        ViewBag.explicacion = "En esta sala de escape se te mostraran una serie de equipos ordenados segun a un jugador de futbol y deberas adivinar que jugador paso por esos equipos. Todos los nombres de los jugadores deben ser escritos en MAYUSCULA";
        return View("tutorial");
    }

    public IActionResult Comenzar()
    {
        return View("habitacion1");
    }

     public IActionResult Habitacion(int sala, string clave)
    {
       if(sala == Escape.GetEstadoJuego()){
        if(Escape.ResolverSala(sala, clave) == true) Escape.GetEstadoJuego();
        if(Escape.GetEstadoJuego() == 5) return View("gano");
      }
      return View("habitacion" + Escape.GetEstadoJuego());
    }

    public IActionResult Creditos()
    {
        ViewBag.texto1 = "Desarrollador del proyecto";
        ViewBag.texto2 = "Ideador y desarrollador del proyecto";
        return View("creditos");
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
