using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PsicopataPedido.Application.Dtos
{
    public class OrderDto : BaseDto
    {
        public decimal Total { get; set; }
        public int UserID { get; set; }
        public UserDto User { get; set; }
        public DateTime OrderDate { get; set; }

    }
}
