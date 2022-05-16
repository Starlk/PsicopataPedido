using PsicopataPedido.Application.Dtos;
using PsicopataPedido.Application.Interfaces.Interfaces;
using PsicopataPedido.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PsicopataPedido.Application.Services
{
    public class ProductServices : IProductServices
    {
        public Task<Product> delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Product>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Product> getOne(int id)
        {
            throw new NotImplementedException();
        }

        public ProductDto save(ProductDto entity)
        {
            throw new NotImplementedException();
        }

        public ProductDto update(ProductDto entity)
        {
            throw new NotImplementedException();
        }
    }
}
