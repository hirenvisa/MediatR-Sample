using MediatR;

namespace WeatherForecast.MediatR.API.Controllers.Weather
{
    public class WeatherForecastRequest: IRequest<IEnumerable<WeatherForecast>> 
    {
        public readonly static WeatherForecastRequest Instance = new();

        private WeatherForecastRequest() { }
    }
}
