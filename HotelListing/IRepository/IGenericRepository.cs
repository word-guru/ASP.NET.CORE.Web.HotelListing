using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace HotelListing.IRepository
{
    public interface IGenericRepository<T> where T : class
    {
        Task<IList<T>>GetAllAsync(
            Expression<Func<T,bool>> expression = null,
            Func<IQueryable<T>,IOrderedQueryable<T>> orderBy = null,
            List<String> includes = null
            );
        Task<T> GetAsync(Expression<Func<T, bool>> expression, List<String> includes = null);
        Task InsertAsync(T entity);
        Task InsertRangeAsync(IEnumerable<T> entities);
        void Update(T entity);
        Task DeleteAsync(int id);
        void DeleteRange(IEnumerable<T> entities);
    }
}
