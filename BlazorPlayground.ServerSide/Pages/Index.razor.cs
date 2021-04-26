using BlazorPlayground.ServerSide.Data;
using BlazorPlayground.ServerSide.Models;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlazorPlayground.ServerSide.Pages
{
    public partial class Index
    {
        protected List<WeatherForecast> WeatherForecasts = new();

        protected WeatherForecastDisplayModeSelection WeatherForecastDisplayModeSelection = new();

        [Inject] protected IWeatherForecastService WeatherForecastService { get; set; }

        protected override async Task OnInitializedAsync()
        {
            WeatherForecasts = await WeatherForecastService.GetForecastAsync(DateTime.Today.AddDays(-7));
        }
    }
}
