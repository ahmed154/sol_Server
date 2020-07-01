using pro_Server.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pro_Server.Services
{
    public interface IWeatherForecastService
    {
        Task<List<WeatherForecast>> GetWeatherForecasts();
    }
}
