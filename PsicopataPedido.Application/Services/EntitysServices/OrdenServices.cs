using PsicopataPedido.Application.Dtos;
using PsicopataPedido.Application.Interfaces.Services;
using PsicopataPedido.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PsicopataPedido.Application.Services.EntitysServices
{
    internal class OrdenServices : IOrderServices
    {
        public Task<Orden> delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Orden>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Orden> getOne(int id)
        {
            throw new NotImplementedException();
        }

        public Task<OrderDto> save(OrderDto entity)
        {
            throw new NotImplementedException();
        }

        public OrderDto update(int id, OrderDto entity)
        {
            throw new NotImplementedException();
        }
    }
}
