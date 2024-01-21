
using GoturBunu.Domain.Core;
using System.Linq.Expressions;

namespace GoturBunu.Application.Services
{
    public interface IEntityRepository<TEntity, TKey>
        where TEntity : class, IEntity<TKey>, new()
        where TKey : IComparable
    {
        Task<TEntity?> FindAsync(Expression<Func<TEntity, bool>> predicate, bool asNoTracking = false, params Expression<Func<TEntity, object>>[] includes);
        Task<TSelect?> FindAsync<TSelect>(Expression<Func<TEntity, bool>> predicate, Expression<Func<TEntity, TSelect>> selector, params Expression<Func<TEntity, object>>[] includes);

        Task<List<TEntity>> GetListAsync();
        Task<List<TEntity>> GetListAsync(bool asNoTracking = false);
        Task<List<TEntity>> GetListAsync(Expression<Func<TEntity, bool>> predicate);
        Task<List<TEntity>> GetListAsync(params Expression<Func<TEntity, object>>[] includes);

        Task<List<TEntity>> GetListAsync(Expression<Func<TEntity, bool>> predicate, bool asNoTracking = false);
        Task<List<TEntity>> GetListAsync(Expression<Func<TEntity, bool>> predicate, params Expression<Func<TEntity, object>>[] includes);
        Task<List<TEntity>> GetListAsync(bool asNoTracking = false, params Expression<Func<TEntity, object>>[] includes);

        Task<List<TEntity>> GetListAsync(Expression<Func<TEntity, bool>> predicate, bool asNoTracking = false, params Expression<Func<TEntity, object>>[] includes);


        Task<List<TSelect>> GetListAsync<TSelect>(Expression<Func<TEntity, TSelect>> selector);
        Task<List<TSelect>> GetListAsync<TSelect>(Expression<Func<TEntity, bool>> predicate, Expression<Func<TEntity, TSelect>> selector);
        Task<List<TSelect>> GetListAsync<TSelect>(Expression<Func<TEntity, TSelect>> selector, params Expression<Func<TEntity, object>>[] includes);
        Task<List<TSelect>> GetListAsync<TSelect>(Expression<Func<TEntity, bool>> predicate, Expression<Func<TEntity, TSelect>> selector, params Expression<Func<TEntity, object>>[] includes);

        Task<List<TEntity>> PaginateAsync(int page, int count, out int total);
        Task<List<TEntity>> PaginateAsync(int page, int count, out int total, bool asNoTracking = false);
        Task<List<TEntity>> PaginateAsync(int page, int count, out int total, Expression<Func<TEntity, bool>> predicate);
        Task<List<TEntity>> PaginateAsync(int page, int count, out int total, params Expression<Func<TEntity, object>>[] includes);
        Task<List<TEntity>> PaginateAsync(int page, int count, out int total, Expression<Func<TEntity, bool>> predicate, bool asNoTracking = false);
        Task<List<TEntity>> PaginateAsync(int page, int count, out int total, Expression<Func<TEntity, bool>> predicate, params Expression<Func<TEntity, object>>[] includes);
        Task<List<TEntity>> PaginateAsync(int page, int count, out int total, bool asNoTracking = false, params Expression<Func<TEntity, object>>[] includes);
        Task<List<TEntity>> PaginateAsync(int page, int count, out int total, Expression<Func<TEntity, bool>> predicate, bool asNoTracking = false, params Expression<Func<TEntity, object>>[] includes);
        Task<List<TSelect>> PaginateAsync<TSelect>(int page, int count, out int total, Expression<Func<TEntity, TSelect>> selector);
        Task<List<TSelect>> PaginateAsync<TSelect>(int page, int count, out int total, Expression<Func<TEntity, bool>> predicate, Expression<Func<TEntity, TSelect>> selector);
        Task<List<TSelect>> PaginateAsync<TSelect>(int page, int count, out int total, Expression<Func<TEntity, TSelect>> selector, params Expression<Func<TEntity, object>>[] includes);
        Task<List<TSelect>> PaginateAsync<TSelect>(int page, int count, out int total, Expression<Func<TEntity, bool>> predicate, Expression<Func<TEntity, TSelect>> selector, params Expression<Func<TEntity, object>>[] includes);

        Task<int> CountAsync();
        Task<int> CountAsync(Expression<Func<TEntity, bool>> predicate);

        TEntity Add(TEntity entity);

        TEntity Update(TEntity entity);

        void Remove(TEntity entity);
    }
}
