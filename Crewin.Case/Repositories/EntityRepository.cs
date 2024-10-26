using Crewin.Case.Context;
using Crewin.Case.Entities;
using Crewin.Case.Repositories.Interface;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Crewin.Case.Repositories
{
    public class EntityRepository<T> : IEntityRepository<T> where T : BaseEntity
    {
        private readonly ApplicationDbContext _context;
        private readonly DbSet<T> _dbSet;

        public EntityRepository(ApplicationDbContext context)
        {
            _context = context;
            _dbSet = context.Set<T>();
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _dbSet.ToListAsync();
        }

        public async Task<T> GetByIdAsync(int id)
        {
            return await _dbSet.FindAsync(id);
        }

        public async Task<IEnumerable<T>> FindAsync(Expression<Func<T, bool>> predicate)
        {
            return await _dbSet.Where(predicate).ToListAsync();
        }

        public async Task AddAsync(T entity)
        {
            await _dbSet.AddAsync(entity);
        }

        public async Task UpdateAsync(T entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
        }

        public async Task DeleteAsync(T entity)
        {
            _dbSet.Remove(entity);
        }

        public async Task<bool> SaveChangesAsync()
        {
            try
            {
                int changes = await _context.SaveChangesAsync();
                return changes > 0; 
            }
            catch (Exception)
            {

                return false;
            }
        }
    }
}