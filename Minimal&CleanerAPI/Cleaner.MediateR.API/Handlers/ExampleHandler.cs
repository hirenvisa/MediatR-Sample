using Cleaner.MediateR.API.Requests;
using Cleaner.MediateR.API.Services;
using MediatR;

namespace Cleaner.MediateR.API.Handlers;

public class ExampleHandler : IRequestHandler<IExampleRequest, IResult>
{
    private readonly GuidService guidService;

    public ExampleHandler(GuidService guidService) => this.guidService = guidService;
    public async Task<IResult> Handle(IExampleRequest request, CancellationToken cancellationToken)
    {
        return Results.Ok(new
        {
            Message = $"The name is: {request.Name} and age was: {request.Age}",
            RequestGuid = request.GuidService.Guid.ToString(),
            ctroGuid = guidService.Guid
        }) ;
    }
}
