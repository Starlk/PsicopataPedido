using Microsoft.EntityFrameworkCore;
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
    public class ShoppinListRepository : BaseRepository<ShoppingList>, IShoppingListRepository
    {
        PsicopataPedidoContext _context;
        public ShoppinListRepository(PsicopataPedidoContext context) : base(context)
        {
            _context = context;
        }

        public async Task<bool> ExistShoppingItem(int user, int product)
        {
          var response =  await _context.ShoppingLists
                .Where(sh => sh.IsDeleted == true && sh.UserId == user && sh.ProductId == product)
                .FirstAsync();
            if(response != null)
            {
                response.IsDeleted = false;
                await base.Update(response);
                return true;
            }
            return false;
        }

        public async Task<IEnumerable<ShoppingList>> GetShoppingListUserAsync(int id)
        {
            return await _context.ShoppingLists
                .Where(s => s.IsDeleted == false && s.UserId == id )
                .Include(c=>c.Product)
                .ToListAsync();
            
        }
       
    }
}
