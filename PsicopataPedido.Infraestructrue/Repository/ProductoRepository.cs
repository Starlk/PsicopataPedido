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
    internal class ProductoRepository : BaseRepository<Product>, IProductRepository
    {
        public ProductoRepository(PsicopataPedidoContext context) : base(context)
        {
        }
    }
}
