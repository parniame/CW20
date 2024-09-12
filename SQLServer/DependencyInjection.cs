using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.DependencyInjection;
using SQLServer.Interfaces;
using SQLServer.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLServer
{
    public static class DependencyInjection
    {
        public static void AddDataAccess(this IServiceCollection services)
        {
            services.AddScoped<IProductRepo,ProductRepo>();
        }
    }
}
