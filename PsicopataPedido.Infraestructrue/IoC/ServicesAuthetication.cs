using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PsicopataPedido.Infraestructrue.IoC
{
    internal static class ServicesAuthetication
    {
        public static IServiceCollection addServiceAuthetication(this IServiceCollection services) 
        {
           
            return services;
        }
    }
}
