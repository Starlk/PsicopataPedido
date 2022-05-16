using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PsicopataPedido.Domain.Entities
{
    public class Orden : BaseEntity
    {
    
        public decimal Total { get; set; }
        public int UserID { get; set; }
        public User User { get; set; }
    }
}
