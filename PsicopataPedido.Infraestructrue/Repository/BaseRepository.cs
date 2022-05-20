using Microsoft.EntityFrameworkCore;
using PsicopataPedido.Application.Interfaces;
using PsicopataPedido.Domain.Entities;
using PsicopataPedido.Infraestructrue.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PsicopataPedido.Infraestructrue.Repository
{
    public class BaseRepository<TEntity> : IRepository<TEntity> where TEntity :  BaseEntity
    {
        PsicopataPedidoContext _context;
        DbSet<TEntity> _dbSet;
       
        public BaseRepository(PsicopataPedidoContext context) 
        {
            _context = context;
            _dbSet = context.Set<TEntity>();
        }
        public async Task<TEntity> DeleteById(int id)
        {
            var result = await GetById(id);
            result.IsDeleted = true;
            _context.SaveChanges();
            return  result;
        }

        public async Task<IEnumerable<TEntity>> GetAll()
        {
            var response = from entity in _context.Set<TEntity>()
                          where entity.IsDeleted == false
                          select entity;
            return response;
        }

        public async Task<TEntity> GetById(int id)
        {
          var entity =  await _context.Set<TEntity>().FindAsync(id);
          return entity;

        }

        public async Task<TEntity> Save(TEntity entity)
        {
            _dbSet.Add(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task<TEntity> Update(TEntity entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return entity;
        }
    }
}
