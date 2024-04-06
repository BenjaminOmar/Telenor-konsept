using Infrastructure.Context;
using Infrastructure.Models;
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

            AddAuthenticationAndAuthorization(services);

            services.AddDbContext<DataContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
            });
            
            services.AddDbContext<IdentityContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
            });

            services.AddIdentityCore<User>()
                .AddEntityFrameworkStores<DataContext>();
            
            return services;
        }
        
        private static IServiceCollection AddRepositories(IServiceCollection services)
        {
            return services;
        }

        private static IServiceCollection AddAuthenticationAndAuthorization(IServiceCollection services)
        {
            services.AddAuthentication()
                .AddBearerToken(IdentityConstants.BearerScheme);
            services.AddIdentityApiEndpoints<User>();

            services.AddAuthorization();
            
            return services;
        }
    }
}