using PsicopataPedido.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PsicopataPedido.Application.Interfaces
{
    public interface IUserRepository : IRepository<User>
    {
        Task<User> Login(User user);
    }
}
