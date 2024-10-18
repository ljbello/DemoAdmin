using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Rize.Admin.Services.MicrosoftGraph.Rest
{
    public static class Bootstrapper
    {
        public static void AddGraphService(this IServiceCollection services, IConfiguration configuration)
        {
            services.Configure<WebOptions>(configuration);
            // https://docs.microsoft.com/en-us/dotnet/standard/microservices-architecture/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests
            services.AddHttpClient<IGraphApiOperations, GraphApiOperationService>();
        }
    }
}