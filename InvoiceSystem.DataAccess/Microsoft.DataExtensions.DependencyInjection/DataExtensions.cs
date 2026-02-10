using InvoiceSystem.DataAccess.Interfaces;
using InvoiceSystem.DataAccess.Interfaces.Implementation;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceSystem.DataAccess.Microsoft.DataExtensions.DependencyInjection
{
    public static class DataExtensions
    {
        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            services.AddScoped<IInvoiceRepository, InvoiceRepository>();
            return services;
        }
    }
}
