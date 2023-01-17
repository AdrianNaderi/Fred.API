using System.Linq.Expressions;

namespace Fred.API.Repository.IRepository
{
    public interface IBaseRepository<T> where T : class
    {
        Task AddAsync(T entity);
        Task RemoveAsync(T entity);
        Task RemoveRangeAsync(Expression<Func<T, bool>> filter);
        Task<T> GetFirstWhereAsync(Expression<Func<T, bool>> filter, string? includeProperties = null, bool tracked = false);
        Task<IEnumerable<T>> GetAllWhereAsync(Expression<Func<T, bool>>? filter = null, string? includeProperties = null);


        //Task<IEnumerable<T>> GetAllAsync();
        //Task<T> GetByIdAsync(int id);

        //Task<T> GetFirstOrDefault(int id);
        //Task<IEnumerable<T>> GetWhere(Expression<Func<T, bool>> predicate);

        //Task<int> CountAll();
        //Task<int> CountWhere(Expression<Func<T, bool>> predicate);
    }
}
