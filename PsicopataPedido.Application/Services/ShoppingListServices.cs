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
    public class ShoppingListServices : IShoppingListServices
    {
        public Task<ShoppingList> delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ShoppingList>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<ShoppingList> getOne(int id)
        {
            throw new NotImplementedException();
        }

        public ShoppingListDto save(ShoppingListDto entity)
        {
            throw new NotImplementedException();
        }

        public ShoppingListDto update(ShoppingListDto entity)
        {
            throw new NotImplementedException();
        }
    }
}
