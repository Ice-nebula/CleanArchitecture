using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace CleanArchitecture.ApplicationCore
{
    public static class DependencyInjectionSettings
    {
        public static IServiceCollection ApplyApplicationCore(this IServiceCollection services)
        {
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            return services;
        } //end method

    }
}