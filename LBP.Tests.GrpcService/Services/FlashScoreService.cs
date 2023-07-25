using Grpc.Core;

namespace LBP.Tests.GrpcService.Services;

public class FlashScoreService : Greeter.GreeterBase
{
    private readonly ILogger<FlashScoreService> logger;

    public FlashScoreService(ILogger<FlashScoreService> logger)
    {
        this.logger = logger;
    }

    public override Task<HelloReply> SayHello(HelloRequest request, ServerCallContext context)
    {
        logger.LogInformation($"Calling {nameof(SayHello)}");

        return Task.FromResult(new HelloReply
        {
            Message = "Hello " + request.Name
        });
    }

    // TODO: Needs implementation for the extra calls in the gRPC Server
}