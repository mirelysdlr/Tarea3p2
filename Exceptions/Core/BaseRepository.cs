using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using organizadordeventos.Infrastructure.Context;
using organizadordeventos.Infrastructure.Interfaces;

namespace organizadordeventos.Infrastructure.Core
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        protected readonly OrgDbContext _context;
        protected readonly DbSet<T> _dbSet;
        
        public BaseRepository(OrgDbContext context)
        {
            _context = context;
            _dbSet = _context.Set<T>();
        }
        
        public virtual async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _dbSet.ToListAsync();
        }
        
        public virtual async Task<T> GetByIdAsync(int id)
        {
            return await _dbSet.FindAsync(id);
        }
        
        public virtual async Task<T> AddAsync(T entity)
        {
            await _dbSet.AddAsync(entity);
            await _context.SaveChangesAsync();
            return entity;
        }
        
        public virtual async Task<T> UpdateAsync(T entity)
        {
            _dbSet.Update(entity);
            await _context.SaveChangesAsync();
            return entity;
        }
        
        public virtual async Task<bool> DeleteAsync(int id)
        {
            var entity = await GetByIdAsync(id);
            if (entity == null) return false;
            
            _dbSet.Remove(entity);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}