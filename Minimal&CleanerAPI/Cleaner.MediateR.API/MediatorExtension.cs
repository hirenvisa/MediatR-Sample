using Cleaner.MediateR.API.Requests;
using MediatR;

namespace Cleaner.MediateR.API;

public static class MediatorExtension
{
    public static WebApplication MediatorGet<TRequest>
        (this WebApplication app, string template) where TRequest : IHttpRequest
    {
        app.MapGet(template, async (IMediator mediator, [AsParameters] TRequest request) => 
           await mediator.Send(request));

        return app;
    }
}
