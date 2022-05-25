using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PsicopataPedido.Application.Interfaces.Services
{
    internal interface IShoppingCar<T>
    {
        Task<IEnumerator<T>> GetShoppingUserCar(int id);
    }
}
