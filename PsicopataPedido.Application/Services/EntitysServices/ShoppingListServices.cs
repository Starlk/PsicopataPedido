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
    public class ShoppingListServices : IShoppingListServices
    {
        IShoppingListRepository _shopping;
        IMapper _mapper;
        IProductRepository _product;

        public ShoppingListServices(IShoppingListRepository shopping, IMapper mapper, IProductRepository product)
        {
            _shopping = shopping;
            _mapper = mapper;
            _product = product;
        }
        public Task<ShoppingList> delete(int id)
        {
            return _shopping.DeleteById(id);
        }

        public async Task<IEnumerable<ShoppingList>> GetAll()
        {
            var shopping = await _shopping.GetAll();

            return shopping;
        }

        public Task<ShoppingList> getOne(int id)
        {
            return _shopping.GetById(id);
        }

        public Task<IEnumerable<ShoppingList>> GetShoppingListAsync(int id)
        {
            return _shopping.GetShoppingListUserAsync(id);
        }

        public async Task<ShoppingListDto> save(ShoppingListDto entity)
        {
            var shopping = _mapper.Map<ShoppingList>(entity);
            var product = await _product.GetById(entity.ProductId);
            if (product == null) throw new Exception("El product no exist");
            if (await _shopping.ExistShoppingItem(entity.UserId, entity.ProductId)) return entity;
            if (EnoughProduct(product, entity.Count)) throw new Exception("No hay suficiente productos");
            _product.discountProductStock(product, entity.Count);
            await _shopping.Save(shopping);
            return entity;
        }

        public ShoppingListDto update(int id, ShoppingListDto entity)
        {
            var shopping = _mapper.Map<ShoppingList>(entity);
            _shopping.Update(shopping);
            return entity;
        }

        protected bool EnoughProduct(Product product,int countProductSell)
        {
            return product.Stock < countProductSell;
        }
    }
}
