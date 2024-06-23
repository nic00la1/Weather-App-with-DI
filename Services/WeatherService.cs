using Models;
using ServiceContracts;

namespace Services;

public class WeatherService : IWeatherService
{
    private readonly List<CityWeather> _cities;

    public WeatherService()
    {
        // This is a dummy data
        _cities = new List<CityWeather>
        {
            new()
            {
                Name = "London",
                CityUniqueCode = "LND",
                DateAndTime = DateTime.Parse("2030-01-01 8:00"),
                Temperature = 0.5
            },
            new()
            {
                Name = "New York",
                CityUniqueCode = "NYC",
                DateAndTime = DateTime.Parse("2030-01-01 3:00"),
                Temperature = 15.6
            },
            new()
            {
                Name = "Paris",
                CityUniqueCode = "PAR",
                DateAndTime = DateTime.Parse("2030-01-01 9:00"),
                Temperature = 27.7
            }
        };
    }

    public List<CityWeather> GetWeatherDetails()
    {
        return _cities;
    }

    public CityWeather? GetWeatherByCityCode(string CityCode)
    {
        CityWeather? city =
            _cities.FirstOrDefault(c => c.CityUniqueCode == CityCode);
        return city;
    }
}
