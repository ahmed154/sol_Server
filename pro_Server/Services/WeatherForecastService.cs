using Microsoft.AspNetCore.Components;
using pro_Server.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace pro_Server.Services
{
    public class WeatherForecastService : IWeatherForecastService
    {
        private readonly HttpClient httpClient;

        public WeatherForecastService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }
        public async Task<List<WeatherForecast>> GetWeatherForecasts()
        {
            return await httpClient.GetJsonAsync<List<WeatherForecast>>("weatherforecast");
        }
    }
}
