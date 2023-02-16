using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using PokemonApiProject.Models;

namespace PokemonApiProject.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        var pokemon = new PokemonInfo();

        return View(pokemon);
    }

    public IActionResult Search(PokemonInfo pokemon)
    {
        pokemon = APIRepository.GetPokemonName(pokemon.PokemonName);
        APIRepository.GetPokemonName(pokemon.PokemonName);
        

        return View(pokemon);
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

