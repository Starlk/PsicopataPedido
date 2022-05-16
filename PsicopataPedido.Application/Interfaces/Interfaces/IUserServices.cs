using PsicopataPedido.Application.Dtos;
using PsicopataPedido.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PsicopataPedido.Application.Interfaces.Interfaces
{
    public interface IUserServices : IServices<UserDto, User>
    {
        bool login(UserDto user);
        string CreateToken(UserDto user, string value);
    }
}
