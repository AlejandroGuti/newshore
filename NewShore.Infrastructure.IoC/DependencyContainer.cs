using Microsoft.Extensions.DependencyInjection;
using NewShore.Domain.Services;
using NewShore.Domain.Services.Interfaces;
using NewShore.Infrastructure.Contexts;
using NewShore.Infrastructure.Repositories;
using NewShore.Infrastructure.Repositories.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace NewShore.Infrastructure.IoC
{
    public class DependenciesContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            services.AddTransient<SeedDb>();

            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IAccountService, AccountService>();

            services.AddScoped<IVivaAirService, VivaAirService>();
        }
    }
}
