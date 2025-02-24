using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace FlightReservationAPI.Infrastructure.Extensions
{
    public static class ServiceCollectionExtensions
    {
        /// <summary>
        /// Registra automáticamente todos los repositorios y servicios en el ensamblado actual.
        /// </summary>
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            var assembly = Assembly.GetExecutingAssembly();

            // Registrar automáticamente todos los repositorios (que terminan en "Repository")
            var repositoryTypes = assembly.GetTypes()
                .Where(t => t.IsClass && !t.IsAbstract && t.Name.EndsWith("Repository"));

            foreach (var repo in repositoryTypes)
            {
                var interfaceType = repo.GetInterfaces().FirstOrDefault(i => i.Name == $"I{repo.Name}");
                if (interfaceType != null)
                {
                    services.AddScoped(interfaceType, repo);
                }
            }

            // Registrar automáticamente todos los servicios (que terminan en "Service")
            var serviceTypes = assembly.GetTypes()
                .Where(t => t.IsClass && !t.IsAbstract && t.Name.EndsWith("Service"));

            foreach (var service in serviceTypes)
            {
                services.AddScoped(service);
            }

            return services;
        }
    }
}
