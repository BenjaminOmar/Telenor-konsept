using Application.Services.Authentication;
using Application.Services.Business;
using Application.Services.Contact;
using Application.Services.Customer;
using Application.Services.Status;
using Application.Services.UserServices;
using Domain.Interfaces.Services.Contact;
using Domain.Interfaces.Services.Customer;
using Domain.Interfaces.Services.Status;
using Domain.Interfaces.Services.User;
using Microsoft.Extensions.DependencyInjection;

namespace Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            AddServices(services);
            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
            services.AddHttpContextAccessor();
            services.AddTransient<ICurrentUserService, CurrentUserService>();
            return services;
        }
        
        private static IServiceCollection AddServices(IServiceCollection services)
        {
            services.AddScoped<IAuthenticationService, AuthenticationService>();
            services.AddScoped<IBusinessService, BusinessService>();
            services.AddScoped<ICustomerService, CustomerService>();
            services.AddScoped<IStatusService, StatusService>();
            services.AddScoped<IBrregService, BrregService>();
            services.AddScoped<IContactService, ContactService>();
            return services;
        }
    }
}