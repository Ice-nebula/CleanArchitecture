using CleanArchitecture.Domain.Interfaces;
using CleanArchitecture.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Infrastructure
{
   public static class DependencyInjectionSettings
    {
        public static IServiceCollection ApplyInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddDbContext<DataContext>(x => x.UseNpgsql(configuration.GetConnectionString("psql"),
                x => x.MigrationsAssembly(typeof(DataContext).Assembly.FullName)));
            return services;
        } //end method
    }
}
