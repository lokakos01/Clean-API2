using FluentValidation;
using Microsoft.Extensions.DependencyInjection;


namespace Application
{
    public static class Dependency
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            var assembly = typeof(Dependency).Assembly;

            services.AddMediatR(configuration => configuration.RegisterServicesFromAssembly(assembly));

            services.AddValidatorsFromAssembly(assembly);

            return services;
        }


    }
}
