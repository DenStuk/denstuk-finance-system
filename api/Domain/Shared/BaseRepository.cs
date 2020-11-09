using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace api.Repository
{
    public class BaseRepository<TEntity> where TEntity : class
    {
        private readonly DbContext _context;
        private readonly DbSet<TEntity> _dbSet;
        
        public BaseRepository(DbContext context)
        {
            _context = context;
            _dbSet = context.Set<TEntity>();
        }

        public virtual async Task<List<TEntity>> GetAll()
        {
            return await _dbSet.ToListAsync();
        }

        public virtual async Task<TEntity> GetOneById(string id)
        {
            return await _dbSet.FindAsync(id);
        }
        
        public virtual async Task<TEntity> GetOneById(int id)
        {
            return await _dbSet.FindAsync(id);
        }

        public virtual async Task Create(TEntity entity)
        {
            await _dbSet.AddAsync(entity);
            _context.SaveChanges();
        }

        public virtual void Update(TEntity entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            _context.SaveChanges();
        }
        
        public virtual void Remove(TEntity item)
        {
            _dbSet.Remove(item);
            _context.SaveChanges();
        }
        
    }
}