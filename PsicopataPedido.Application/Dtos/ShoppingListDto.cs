using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PsicopataPedido.Application.Dtos
{
    public class ShoppingListDto 
    {
        public int Count { get; set; }
        public DateTime date { get; set; }
        public int ProductId { get; set; }
        public int UserId { get; set; }
      
    }
}
