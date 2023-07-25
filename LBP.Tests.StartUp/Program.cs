using LBP.Tests.StartUp;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

using var host = Host.CreateDefaultBuilder(args)
    .ConfigureLogging(logging =>
    {
        logging.ClearProviders();
        logging.AddConsole();
    })
    .ConfigureServices(services =>
    {
        // TODO: Add a Service for GrpcService Client
        // TODO: Add a Service for FlashScore Bot
        // TODO: Add a Service for FlashScore Worker which will be in caharge of downloading and viewing the data
    })
    .Build();
