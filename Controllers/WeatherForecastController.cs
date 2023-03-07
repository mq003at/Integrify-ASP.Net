using Microsoft.AspNetCore.Mvc;
using dotnet.Services;

namespace dotnet.Controllers;

[ApiController]
[Route("[controller]s")]
public class WeatherForecastController : ControllerBase
{
    private readonly ILogger<WeatherForecastController> _logger;
    private readonly IWeatherForecastService _service;

    public WeatherForecastController(
        ILogger<WeatherForecastController> logger,
        IWeatherForecastService service
    )
    {
        _logger = logger;
        _service = service;
        _logger.LogInformation("This is the constructor.");
        _logger.LogError("Something goes wrong");
    }

    [HttpGet]
    public IEnumerable<WeatherForecast> Get()
    {
        return _service.Forecast(3);
    }

    [HttpGet("{days}")]
    public IEnumerable<WeatherForecast> Get(int days)
    {
        return _service.Forecast(days);
    }
}
