using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using PsicopataPedido.Application.Validators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PsicopataPedido.Application.IoC
{
    public static class Validators
    {
        public static void AddValidator(this IServiceCollection services)
        {
            services.AddFluentValidation(o => o.RegisterValidatorsFromAssemblyContaining<UserValidator>());
        }
    }
}
