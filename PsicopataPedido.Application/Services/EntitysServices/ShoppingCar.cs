using PsicopataPedido.Application.Interfaces;
using PsicopataPedido.Application.Interfaces.Services;
using PsicopataPedido.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PsicopataPedido.Application.Services
{
    internal class ShoppingCar : IShoppingCar<ShoppingList>
    {
        private readonly IProductRepository _product;
        private readonly IShoppingListRepository _shopping;
        private readonly PsicopataPedidoContext _context;

        public ShoppingCar(PsicopataPedidoContext context, IProductRepository product, IShoppingListRepository shopping)
        {
            _product = product;
            _shopping = shopping;
            _context = context;
        }
        public Task<IEnumerator<ShoppingList>> GetShoppingUserCar(int id)
        {

            return null;        
        }
    }
}
