using Microsoft.Extensions.DependencyInjection;
using NewShore.Domain.Services;
using NewShore.Domain.Services.Interfaces;
using NewShore.Infrastructure.Contexts;
using NewShore.Infrastructure.Repositories;
using NewShore.Infrastructure.Repositories.Interface;
using NewShore.Infrastructure.Repositories.Interfaces;

namespace NewShore.Infrastructure.IoC
{
    public class DependenciesContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            services.AddTransient<SeedDb>();
            services.AddTransient<IUserRepository, UserRepository>();
            services.AddTransient<ICustomerRepository, CustomerRepository>();
            services.AddTransient<ITransportRepository, TransportRepository>();

            services.AddScoped<IAccountService, AccountService>();
            services.AddScoped<IVivaAirService, VivaAirService>();
            services.AddScoped<ICustomerService, CustomerService>();
        }
    }
}
