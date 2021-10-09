using AspNetCoreData.Context;
using AspNetCoreData.Repository;
using AspNetCoreDomain.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace AspNetCoreInfrastructure.DependencyInjection
{
    public class ConfigureRepository
    {
        public static void ConfigureDependenciesRepository(IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped(typeof(IRepository<>), typeof(BaseRepository<>));
            serviceCollection.AddDbContext<MyContext>(options => options.UseSqlServer(
                @"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=TestingDDD;Data Source=I9DEV-001\SQLEXPRESS"));
        }
    }
}
