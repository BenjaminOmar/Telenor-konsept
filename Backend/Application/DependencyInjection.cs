using Application.Services.Authentication;
using Application.Services.Business;
using Application.Services.Customer;
using Domain.Interfaces.Services.Customer;
using Microsoft.Extensions.DependencyInjection;

namespace Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            AddServices(services);
            return services;
        }
        
        private static IServiceCollection AddServices(IServiceCollection services)
        {
            services.AddScoped<IAuthenticationService, AuthenticationService>();
            services.AddScoped<IBusinessService, BusinessService>();
            services.AddScoped<ICustomerService, CustomerService>();
            return services;
        }
    }
}