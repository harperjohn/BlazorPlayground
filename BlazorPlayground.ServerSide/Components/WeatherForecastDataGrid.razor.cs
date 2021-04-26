using BlazorPlayground.ServerSide.Data;
using BlazorPlayground.ServerSide.Models;
using Microsoft.AspNetCore.Components;
using System.Collections.Generic;

namespace BlazorPlayground.ServerSide.Components
{
    public partial class WeatherForecastDataGrid
    {        
        [Parameter]
        public List<WeatherForecast> Data { get; set; }

        [Parameter]
        public WeatherForecastDisplayModeSelection WeatherForecastDisplayModeSelection { get; set; }
    }
}
