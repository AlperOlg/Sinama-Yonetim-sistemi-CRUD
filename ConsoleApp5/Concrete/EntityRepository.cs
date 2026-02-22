using ConsoleApp5.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5.Concrete
{
    public class EntityRepository<TContext, TEntity> : IEntityRepository<TEntity> where TContext : DbContext
        where TEntity : class, new()
    {
        private readonly TContext _context;
        public EntityRepository(TContext context)
        {
            _context = context;
        }

        public async Task AddAsync(TEntity entity)
        {
            if (entity == null) { throw new ArgumentNullException(); }
            await _context.Set<TEntity>().AddAsync(entity);
            await _context.SaveChangesAsync();

        }

        public async Task<ICollection<TEntity>> GetAllAsync(Expression<Func<TEntity, bool>> filter = null)
        {
            IQueryable<TEntity> query = _context.Set<TEntity>();
            if (filter != null)
            { query = query.Where(filter); }
            return await query.ToListAsync();
        }

        public async Task RemoveAsync(TEntity entity)
        {
            if (entity == null) { throw new ArgumentNullException(); }
            _context.Set<TEntity>().Remove(entity);
            await _context.SaveChangesAsync();
        }

        public async Task RemoveIDAsync(int ID)
        {
            if (ID <= 0) { throw new ArgumentOutOfRangeException(); }
            var entity = await _context.Set<TEntity>().FindAsync(ID);
            if (entity == null) { throw new ArgumentNullException(); }
            _context.Set<TEntity>().Remove(entity);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(TEntity entity)
        {
            if(entity == null) { throw new ArgumentNullException(); }
            _context.Update(entity);
            await _context.SaveChangesAsync();
        }
    }
}
