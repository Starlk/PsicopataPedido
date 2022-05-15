using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PsicopataPedido.Domain.Entities
{
   public class Product : BaseEntity
    {
        public string Name { get; set; }
        [MaxLength(50)]
        public string? Description { get; set; }
        public decimal Price { get; set; }  
        public int Stock { get; set; }
        public virtual ICollection<Category> Categories { get; set; }
        public virtual ICollection<ShoppingList> ShoppingLists { get; set; }
        
    }
}
