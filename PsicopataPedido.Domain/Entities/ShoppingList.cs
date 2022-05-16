using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PsicopataPedido.Domain.Entities
{
    public class ShoppingList : BaseEntity 
    {
        public int Count { get; set; }
        public DateTime date { get; set; }

        public int ProductId { get; set; }
        public Product Product { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }

    }
}
