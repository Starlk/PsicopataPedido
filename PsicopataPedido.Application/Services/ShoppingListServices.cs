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

        public ShoppingListServices(IShoppingListRepository shopping, IMapper mapper)
        {
            _shopping = shopping;
            _mapper = mapper;
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

        public ShoppingListDto save(ShoppingListDto entity)
        {
            var shopping = _mapper.Map<ShoppingList>(entity);
            _shopping.Save(shopping);
            return entity;
        }

        public ShoppingListDto update(ShoppingListDto entity)
        {
            var shopping = _mapper.Map<ShoppingList>(entity);
            _shopping.Update(shopping);
            return entity;
        }
    }
}
