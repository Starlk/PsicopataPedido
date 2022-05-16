using PsicopataPedido.Application.Interfaces;
using PsicopataPedido.Domain.Entities;
using PsicopataPedido.Infraestructrue.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PsicopataPedido.Infraestructrue.Repository
{
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        PsicopataPedidoContext _context;
        public UserRepository(PsicopataPedidoContext context): base(context)
        {
            _context = context;
        }

        public  async Task<User> Login(User user)
        {
            return  _context.users.Where(u => u.Email == user.Email && u.Password == user.Password).FirstOrDefault();
            

        }
    }
}
