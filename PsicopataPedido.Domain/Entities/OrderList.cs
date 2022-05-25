using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PsicopataPedido.Domain.Entities
{
    public class OrderList : BaseEntity

    {
        public int OrderID { get; set; }
        public Orden orden { get; set; }
        public int ProductoID { get; set; }
        public Product product { get; set; }
        public int quantity { get; set; }

    }
}