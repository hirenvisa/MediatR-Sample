using Cleaner.MediateR.API.Requests;
using Cleaner.MediateR.API.Services;
using MediatR;

namespace Cleaner.MediateR.API.Handlers;

public class WeatherForecastHandler : IRequestHandler<WeatherRequest, IResult>
{
    public readonly WeatherService _service;

    public WeatherForecastHandler(WeatherService service)
    {
        _service = service;
    }

    public async Task<IResult> Handle(WeatherRequest request, CancellationToken cancellationToken)
    {
        var forecasts =  await _service.GetWeatherByCityAsync(request.City, request.Days);
        return Results.Ok(forecasts);
    }
}
