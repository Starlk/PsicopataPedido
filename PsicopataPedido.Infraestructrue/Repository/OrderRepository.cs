using PsicopataPedido.Application.Interfaces.Repository;
using PsicopataPedido.Domain.Entities;
using PsicopataPedido.Infraestructrue.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PsicopataPedido.Infraestructrue.Repository
{
    internal class OrderRepository : BaseRepository<Orden>, IOrderRepository
    {
        public OrderRepository(PsicopataPedidoContext context) : base(context)
        {
        }
    }
}
