using PsicopataPedido.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PsicopataPedido.Application.Interfaces
{
    public interface IShoppingListRepository : IRepository<ShoppingList>
    {
        Task<IEnumerable<ShoppingList>> GetShoppingListUserAsync(int id);
        Task<bool> ExistShoppingItem(int user, int product);
    }
}
