using DearlerPlatform.Core.Repository;
using DearlerPlatform.Domain.UserInfo;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DearlerPlatform.Extensions
{
    public static class RepositoryRegisterExtension
    {
        /// <summary>
        /// 通过反射注册仓储服务
        /// </summary>
        /// <param name="services"></param>
        /// <returns></returns>
        public static IServiceCollection RepositoryRegister(this IServiceCollection services)
        {
            var assCore = Assembly.Load("DearlerPlatform.Core");

            var implementationType = assCore.GetTypes().FirstOrDefault(m => m.Name == "Repository`1");

            var interfaceType = implementationType.GetInterface("IRepository`1").GetGenericTypeDefinition();

            if (interfaceType != null && implementationType != null)
            {
                services.AddTransient(interfaceType, implementationType);
            }

            return services;
        }


        public static IServiceCollection ServiceRegister(this IServiceCollection services)
        {
            var assService = Assembly.Load("DearlerPlatform.Service");

            var implementationTypes = assService.GetTypes().Where(m => m.IsAssignableTo(typeof(IocTag)) &&
            !m.IsAbstract &&
            !m.IsInterface);

            foreach (var implementationType in implementationTypes)
            {
                var interfaceType = implementationType.GetInterfaces().Where(m => m != typeof(IocTag)).FirstOrDefault();
                if (interfaceType != null)
                {
                    services.AddTransient(interfaceType, implementationType);
                }
            }

            return services;
        }
    }
}
