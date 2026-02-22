using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5.Abstract
{
    public interface IEntityRepository<T> where T: class, new()
    {
        Task<ICollection<T>> GetAllAsync(Expression<Func<T,bool>> filter = null);
        Task AddAsync(T entity);
        Task RemoveAsync(T entity);
        Task RemoveIDAsync(int ID);
        Task UpdateAsync(T Entity);
    }
}
