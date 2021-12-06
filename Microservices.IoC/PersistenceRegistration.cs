using Banking.Application.Interfaces;
using Banking.Application.Services;
using Banking.Data.Context;
using Banking.Data.Repository;
using Banking.Domain.CommandHandlers;
using Banking.Domain.Commands;
using Banking.Domain.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Transfer.Application.Interfaces;
using Transfer.Data.Context;

namespace Microservices.IoC
{
    public class PersistenceRegistration
    {
        //Banking microservice IoC
        public static void AddBankingPersistenceServices(IServiceCollection services, IConfiguration configuration)
        {
            services.AddTransient<IAccountService, AccountService>();
            services.AddTransient<IAccountRepository, AccountRepository>();
            services.AddTransient<IRequestHandler<CreateTransferCommand, bool>, TransferCommandHandler>();
            services.AddDbContext<BankingDbContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("BankingDBConnectionString")));
        }

        //Transfer microservice IoC
        public static void AddTransferPersistenceServices(IServiceCollection services, IConfiguration configuration)
        {
            services.AddTransient<ITransferService, TransferService>();
            services.AddTransient<ITransferRepository, TransferRepository>();
            services.AddDbContext<TransferDbContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("TransferDBConnectionString")));
        }
    }
   
}
