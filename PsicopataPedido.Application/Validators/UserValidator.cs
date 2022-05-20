using FluentValidation;
using PsicopataPedido.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PsicopataPedido.Application.Validators
{
    public class UserValidator : AbstractValidator<UserDto>
    {
        public UserValidator()
        {
            RuleFor(x => x.Email)
                .EmailAddress()
                .NotNull()
                .WithMessage("Should be email");
            RuleFor(x => x.Name)
                .NotNull();
        }
    }
}
