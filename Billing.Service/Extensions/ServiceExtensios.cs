using System;
using System.Linq;
using System.Reflection;
using Microsoft.Extensions.DependencyInjection;

namespace Billing.Service.Extensions
{
    public static class ServiceExtensions
    {
        /// <summary>
        /// Adds all the services at the same time
        /// </summary>
        public static IServiceCollection AddAppServices(this IServiceCollection services)
        {
            var servicesNamespace = $"Billing.Service.Services.Implementations";

            // Getting the assembly
            Assembly assembly = Assembly.GetExecutingAssembly();

            // Getting the types
            var serviceTypes = assembly.ExportedTypes.Where(x =>
                x.FullName.StartsWith(servicesNamespace) && x.Namespace != $"{servicesNamespace}.Base")
                 .ToList();

            // Combining the IService with the Serv
            var servicesCombined = serviceTypes.Select(item =>
            new
            {
                _implementation = item,
                _interface = item.GetInterface($"I{item.Name}"),
            }).ToList();

            foreach (var item in servicesCombined)
                services.AddScoped(item._interface, item._implementation);

            return services;
        }
    }
}