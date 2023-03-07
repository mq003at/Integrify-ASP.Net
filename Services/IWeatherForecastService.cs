using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnet.Services;

public interface IWeatherForecastService
{
    IEnumerable<dotnet.WeatherForecast> Forecast(int days);
}
