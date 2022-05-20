using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PsicopataPedido.Application.Interfaces.Interfaces
{
    public interface IServices<TEntityDto, TEntity> where TEntityDto :class 
    {
        TEntityDto save(TEntityDto entity);
        Task<TEntity> delete(int id);
        TEntityDto update(int id,TEntityDto entity);
        Task<IEnumerable<TEntity>> GetAll();

        Task<TEntity> getOne(int id);
    }
}
