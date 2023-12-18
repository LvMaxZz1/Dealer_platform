using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using DearlerPlatform.Domain;
using Microsoft.Extensions.DependencyInjection;

namespace DearlerPlatform.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection RepositoryRegister(this IServiceCollection services)
        {
            var asmCore = Assembly.Load("DearlerPlatform.Core");
            var implementationType = asmCore.GetTypes().FirstOrDefault(m =>
            m.Name == "Repository`1"
             );
            // var interfaceType = implementationType.GetInterfaces().FirstOrDefault();
            var interfaceType = implementationType.GetInterface("IRepository`1").GetGenericTypeDefinition();
            services.AddTransient(interfaceType, implementationType);
            return services;
        }
        public static IServiceCollection ServicesRegister(this IServiceCollection services)
        {
            var asmService = Assembly.Load("DearlerPlatform.Service");
            var implementationTypes = asmService.GetTypes().Where(
                m => m.IsAssignableTo(typeof(IocTag)) &&
                !m.IsAbstract &&
                !m.IsInterface
            );
            foreach (var implementationType in implementationTypes)
            {
                var interfaceType = implementationType.GetInterfaces().Where(m => m != typeof(IocTag)).FirstOrDefault();
                services.AddTransient(interfaceType, implementationType);
            }
            return services;
        }
    }
}