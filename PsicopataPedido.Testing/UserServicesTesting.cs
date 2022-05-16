using PsicopataPedido.Application.Dtos;
using PsicopataPedido.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace PsicopataPedido.Testing
{
    public class UserServicesTesting
    {
        [Fact]
        public void ShouldSaveUser() 
        {
            UserDto user = new UserDto { Email="algo", Password="100", Wallet=1000,LastName="Rodrigue", Name="pepito"};
        }
    }
}
