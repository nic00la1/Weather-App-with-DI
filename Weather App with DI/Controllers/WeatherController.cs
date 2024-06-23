using Microsoft.AspNetCore.Mvc;
using Models;
using ServiceContracts;

namespace Weather_App_with_DI.Controllers;

public class WeatherController : Controller
{
    private readonly IWeatherService _weatherService;

    public WeatherController(IWeatherService weatherService)
    {
        _weatherService = weatherService;
    }

    [Route("/")]
    public IActionResult Index()
    {
        List<CityWeather> cities = _weatherService.GetWeatherDetails();
        return View(cities);
    }

    [Route("/weather/{cityCode?}")]
    public IActionResult Details(string? cityCode)
    {
        if (string.IsNullOrEmpty(cityCode))
            return View();

        CityWeather? city = _weatherService.GetWeatherByCityCode(cityCode);
        return View(city);
    }
}
