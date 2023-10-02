using Cleaner.MediateR.API;
using Cleaner.MediateR.API.Requests;
using Cleaner.MediateR.API.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<GuidService>();
builder.Services.AddSingleton<WeatherService>();

builder.Services.AddMediatR(cfg =>
{
    cfg.RegisterServicesFromAssembly(typeof(Program).Assembly);    
});

var app = builder.Build(); 

app.MediatorGet<IExampleRequest>("foo-endpoint/{name}");
app.MediatorGet<WeatherRequest>("forecast/{city}");

app.Run();
 
 