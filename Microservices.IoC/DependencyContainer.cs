using Banking.Application.Interfaces;
using Banking.Application.Services;
using Banking.Data.Context;
using Banking.Data.Repository;
using Banking.Domain.CommandHandlers;
using Banking.Domain.Commands;
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
        public static void AddApplicationServices(IServiceCollection services)
        {
            services.AddMediatR(Assembly.GetExecutingAssembly());
            services.AddTransient<IEventBus, RabbitMQBus>();
        }
    }
}
