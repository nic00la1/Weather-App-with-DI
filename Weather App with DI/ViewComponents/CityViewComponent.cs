using Microsoft.AspNetCore.Mvc;
using Models;

namespace Weather_App_with_DI.ViewComponents;

public class CityViewComponent : ViewComponent
{
    public async Task<IViewComponentResult> InvokeAsync(CityWeather city)
    {
        ViewBag.CityCssClass = GetCssClassByCelcius(city.Temperature);
        return View(city);
    }

    private string GetCssClassByCelcius(double temperature)
    {
        return temperature switch
        {
            < 6.7 => "blue-back",
            >= 6.7 and <= 23.4 => "green-back",
            _ => "orange-back"
        };
    }
}
