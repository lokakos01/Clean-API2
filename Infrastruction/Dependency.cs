using Infrastruction.Database;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastruction
{
    public static class Dependency
    {
        public static IServiceCollection AddInfrastruction(this IServiceCollection services)
        {
            services.AddSingleton<MockDatabase>();
            return services;
        }

    }
}
    

