using Microservice.Infrastructure.Bus;
using MicroServicesRabbitMQ.Domain.Bus;
using Microsoft.Extensions.DependencyInjection;

namespace Microservices.IoC
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            services.AddTransient<IEventBus, RabbitMQBus>();
        }
    }
}
