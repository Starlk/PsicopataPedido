using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace PsicopataPedido.Application.IoC
{
    public static class Mapper
    {
        public static void AddAppRegister(this IServiceCollection services, Assembly[] assemblies) 
        {
            services.AddAutoMapper(assemblies);
        }
    }
}
