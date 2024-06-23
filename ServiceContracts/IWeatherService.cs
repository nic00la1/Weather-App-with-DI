using Models;

namespace ServiceContracts;

public interface IWeatherService
{
    // Returns a list of CityWeather objects that contains weather details of cities
    List<CityWeather>
        GetWeatherDetails();

    // Returns an object of CityWeather based on the given city code
    CityWeather? GetWeatherByCityCode(string CityCode);
}
