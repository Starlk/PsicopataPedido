using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PsicopataPedido.Application.Interfaces;
using PsicopataPedido.Application.Interfaces.Interfaces;
using PsicopataPedido.Application.Services;
using PsicopataPedido.Infraestructrue.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PsicopataPedido.Infraestructrue.IoC
{
    public static class ServicesRegister
    {
        public static IServiceCollection AddRegisterServices(this IServiceCollection services) 
        {
     
            services.AddScoped<IUserServices, UserServices>();
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IProductServices, ProductServices>();
            services.AddScoped<IProductRepository, ProductoRepository>();
            services.AddScoped<IShoppingListServices, ShoppingListServices>();
            services.AddScoped<IShoppingListRepository, ShoppinListRepository>();
            services.AddScoped<ICategoryServices, CategoryServices>();
            services.AddScoped<ICategoryRepository, CategoryRepository>();

            return services;
        }
    }
}
