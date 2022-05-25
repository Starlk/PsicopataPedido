﻿using PsicopataPedido.Application.Dtos;
using PsicopataPedido.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PsicopataPedido.Application.Interfaces.Interfaces
{
    public interface IShoppingListServices : IServices<ShoppingListDto, ShoppingList>
    {
       Task<IEnumerable<ShoppingList>> GetShoppingListAsync(int id);
    }
}
