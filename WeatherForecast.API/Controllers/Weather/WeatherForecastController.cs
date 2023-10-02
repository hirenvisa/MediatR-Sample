using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace WeatherForecast.MediatR.API.Controllers.Weather
{
    public class WeatherForecastController : Controller
    {
        private readonly IMediator _mediator;
        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(IMediator mediator, ILogger<WeatherForecastController> logger)
        {
            _mediator = mediator;
            _logger = logger;
        }

        [HttpGet("weather")]
        public async Task<IActionResult> GetWeatherForecast()
        {
            var weather = _mediator.Send(WeatherForecastRequest.Instance);
            return Ok(weather);
        }
    }
}
