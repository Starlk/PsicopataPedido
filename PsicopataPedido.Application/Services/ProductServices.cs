using AutoMapper;
using PsicopataPedido.Application.Dtos;
using PsicopataPedido.Application.Interfaces;
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
        IProductRepository _product;
        IMapper _mapper;
        public ProductServices(IProductRepository product, IMapper mapper)
        {
            _product = product;
            _mapper = mapper;
        }
        public Task<Product> delete(int id)
        {
            return _product.DeleteById(id);
        }

        public async  Task<IEnumerable<Product>> GetAll()
        {
            var productList = await _product.GetAll();

            return productList;
        }

        public Task<Product> getOne(int id)
        {
            return _product.GetById(id);
        }

        public ProductDto save(ProductDto entity)
        {
            var product = _mapper.Map<Product>(entity);
            _product.Save(product);
            return entity;
        }

        public ProductDto update(ProductDto entity)
        {
            var product = _mapper.Map<Product>(entity);
            _product.Update(product);
            return entity;
        }
    }
}
