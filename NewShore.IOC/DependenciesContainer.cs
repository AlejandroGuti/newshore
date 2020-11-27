using Microsoft.Extensions.DependencyInjection;
using NewShore.Domain.Services;
using NewShore.Domain.Services.Interfaces;

namespace NewShore.IOC
{
    public class DependenciesContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            services.AddScoped<IAccountService, AccountService>();
        }
    }
}
