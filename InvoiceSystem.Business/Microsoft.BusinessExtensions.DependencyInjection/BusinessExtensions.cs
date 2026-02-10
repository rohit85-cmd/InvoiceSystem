using InvoiceSystem.Business.Services;
using InvoiceSystem.Business.Services.Implementation;
using Microsoft.Extensions.DependencyInjection;

namespace InvoiceSystem.Business.Microsoft.BusinessExtensions.DependencyInjection
{
    public static class BusinessExtensions
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddScoped<IInvoiceService, InvoiceService>();
            return services;
        }
    }
}
