using AspNetCoreDomain.Interfaces.Services.User;
using AspNetCoreService.Services;
using Microsoft.Extensions.DependencyInjection;

namespace AspNetCoreInfrastructure.DependencyInjection
{
    public class ConfigureService
    {
        public static void ConfigureDependenciesService(IServiceCollection serviceCollection)
        {
            serviceCollection.AddTransient<IUserService, UserService>();
        }
    }
}
