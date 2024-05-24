using Application.RepositoryInterfaces;
using Domain.Helpers;
using Domain.Interfaces.Repositories;
using Infrastructure.Configuration;
using Infrastructure.Context;
using Infrastructure.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            AddRepositories(services);

            AddConfiguration(services, configuration);

            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
            
            services.AddDbContext<DataContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
            });
            
            return services;
        }

        private static IServiceCollection AddConfiguration(IServiceCollection services, IConfiguration configuration)
        {
            services.AddSingleton<IEnvironmentSettings>(provider => new EnvironmentSettings(configuration));

            return services;
        }
        
        private static IServiceCollection AddRepositories(IServiceCollection services)
        {
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IBusinessRepository, BusinessRepository>();
            services.AddScoped<ICustomerRepository, CustomerRepository>();
            services.AddScoped<IStatusRepository, StatusRepository>();
            
            return services;
        }
        
    }
}