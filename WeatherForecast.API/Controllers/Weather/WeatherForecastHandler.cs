﻿using MediatR;

namespace WeatherForecast.MediatR.API.Controllers.Weather
{
    public class WeatherForecastHandler :
           IRequestHandler<WeatherForecastRequest, IEnumerable<WeatherForecast>>
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };
        public Task<IEnumerable<WeatherForecast>> Handle(WeatherForecastRequest request, CancellationToken cancellationToken)
        {
            var result = Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            });
            return Task.FromResult(result);
        }
    }
}
