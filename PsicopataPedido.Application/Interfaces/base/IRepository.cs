using PsicopataPedido.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PsicopataPedido.Application.Interfaces
{
    public interface IRepository<T> where T : BaseEntity
    {
        Task<T> GetById(int id);
        Task<T> Save(T entity);
        Task<T> DeleteById(int id);
        Task<T> Update(T entity);
        Task<IEnumerable<T>> GetAll();
        
    } 
}
