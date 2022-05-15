using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PsicopataPedido.Domain.Entities
{
    public class User :  BaseEntity
    {
        [MaxLength(50)]
        public string? Name { get; set; }
        [MaxLength(50)]
        public string? LastName { get; set; }
        [MaxLength(70)]
        public string? Email { get; set; }
        [MaxLength(30)]
        public string? Password { get; set; }
        public decimal? Wallet { get; set; }
        public bool isAdmin { get; set; }
        public virtual ICollection<Orden> ordens { get; set; }
        public virtual ICollection<ShoppingList> ShoppingLists { get; set; }

    }
}
