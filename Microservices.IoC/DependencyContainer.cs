using Banking.Application.Interfaces;
using Banking.Application.Services;
using Banking.Data.Context;
using Banking.Data.Repository;
using Banking.Domain.Interfaces;
using MediatR;
using Microservice.Infrastructure.Bus;
using MicroServicesRabbitMQ.Domain.Bus;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace Microservices.IoC
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services,IConfiguration configuration )
        {
            services.AddMediatR(Assembly.GetExecutingAssembly());
            services.AddTransient<IEventBus, RabbitMQBus>();
            services.AddTransient<IAccountService, AccountService>();
            services.AddTransient<IAccountRepository, AccountRepository>();
            services.AddDbContext<BankingDbContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("BankingDBConnectionString")));
        }
    }
}
