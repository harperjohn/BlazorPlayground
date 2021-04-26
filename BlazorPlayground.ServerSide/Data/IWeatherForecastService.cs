using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlazorPlayground.ServerSide.Data
{
    public interface IWeatherForecastService
    {
        Task<List<WeatherForecast>> GetForecastAsync(DateTime startDate);
    }
}