
using GoturBunu.Application.Services;
using GoturBunu.Domain.Core;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace GoturBunu.Persistance.Services
{
    public class BaseEntityRepository<TEntity, TKey, TContext> : IEntityRepository<TEntity, TKey>
        where TEntity : class, IEntity<TKey>, new()
        where TContext : DbContext
        where TKey : IComparable
    {
        protected readonly TContext context;
        public BaseEntityRepository(TContext context)
        {
            this.context = context;
        }

        public TEntity Add(TEntity entity)
        {
            var entry = context.Add(entity);
            return entry.Entity;
        }

        public void Remove(TEntity entity)
        {
            context.Remove(entity);
        }

        public TEntity Update(TEntity entity)
        {
            var entry = context.Update(entity);
            return entry.Entity;
        }

        public Task<int> CountAsync()
        {
            return context.Set<TEntity>().CountAsync();
        }

        public Task<int> CountAsync(Expression<Func<TEntity, bool>> predicate)
        {
            return context.Set<TEntity>().Where(predicate).CountAsync();
        }

        public Task<TEntity?> FindAsync(Expression<Func<TEntity, bool>> predicate, bool asNoTracking = false, params Expression<Func<TEntity, object>>[] includes)
        {
            throw new NotImplementedException();
        }

        public Task<TSelect?> FindAsync<TSelect>(Expression<Func<TEntity, bool>> predicate, Expression<Func<TEntity, TSelect>> selector, params Expression<Func<TEntity, object>>[] includes)
        {
            throw new NotImplementedException();
        }

        public Task<List<TEntity>> GetListAsync()
        {
            return context.Set<TEntity>().ToListAsync();
        }

        public Task<List<TEntity>> GetListAsync(bool asNoTracking = false)
        {
            return !asNoTracking ? context.Set<TEntity>().ToListAsync() : context.Set<TEntity>().AsNoTracking().ToListAsync();
        }

        public Task<List<TEntity>> GetListAsync(Expression<Func<TEntity, bool>> predicate)
        {
            return context.Set<TEntity>().Where(predicate).ToListAsync();
        }

        public Task<List<TEntity>> GetListAsync(params Expression<Func<TEntity, object>>[] includes)
        {
            var query = (IQueryable<TEntity>)context.Set<TEntity>();

            //Apply eager loading
            foreach (Expression<Func<TEntity, object>> navigationProperty in includes)
                query = query.Include(navigationProperty);

            return query.ToListAsync();
        }

        public Task<List<TEntity>> GetListAsync(Expression<Func<TEntity, bool>> predicate, bool asNoTracking = false)
        {
            return !asNoTracking ? context.Set<TEntity>().Where(predicate).ToListAsync() : context.Set<TEntity>().Where(predicate).AsNoTracking().ToListAsync();
        }

        public Task<List<TEntity>> GetListAsync(Expression<Func<TEntity, bool>> predicate, params Expression<Func<TEntity, object>>[] includes)
        {
            var query = context.Set<TEntity>().Where(predicate);

            //Apply eager loading
            foreach (Expression<Func<TEntity, object>> navigationProperty in includes)
                query = query.Include(navigationProperty);

            return query.ToListAsync();
        }

        public Task<List<TEntity>> GetListAsync(bool asNoTracking = false, params Expression<Func<TEntity, object>>[] includes)
        {
            var query = (IQueryable<TEntity>)context.Set<TEntity>();

            //Apply eager loading
            foreach (Expression<Func<TEntity, object>> navigationProperty in includes)
                query = query.Include(navigationProperty);

            return !asNoTracking ? query.ToListAsync() : query.AsNoTracking().ToListAsync();
        }

        public Task<List<TEntity>> GetListAsync(Expression<Func<TEntity, bool>> predicate, bool asNoTracking = false, params Expression<Func<TEntity, object>>[] includes)
        {
            var query = context.Set<TEntity>().Where(predicate);

            //Apply eager loading
            foreach (Expression<Func<TEntity, object>> navigationProperty in includes)
                query = query.Include(navigationProperty);

            return !asNoTracking ? query.ToListAsync() : query.AsNoTracking().ToListAsync();
        }

        public Task<List<TSelect>> GetListAsync<TSelect>(Expression<Func<TEntity, TSelect>> selector)
        {
            return context.Set<TEntity>().Select(selector).ToListAsync();
        }

        public Task<List<TSelect>> GetListAsync<TSelect>(Expression<Func<TEntity, bool>> predicate, Expression<Func<TEntity, TSelect>> selector)
        {
            return context.Set<TEntity>().Where(predicate).Select(selector).ToListAsync();
        }

        public Task<List<TSelect>> GetListAsync<TSelect>(Expression<Func<TEntity, TSelect>> selector, params Expression<Func<TEntity, object>>[] includes)
        {
            var query = (IQueryable<TEntity>)context.Set<TEntity>();

            //Apply eager loading
            foreach (Expression<Func<TEntity, object>> navigationProperty in includes)
                query = query.Include(navigationProperty);

            return query.Select(selector).ToListAsync();
        }

        public Task<List<TSelect>> GetListAsync<TSelect>(Expression<Func<TEntity, bool>> predicate, Expression<Func<TEntity, TSelect>> selector, params Expression<Func<TEntity, object>>[] includes)
        {
            var query = context.Set<TEntity>().Where(predicate);

            //Apply eager loading
            foreach (Expression<Func<TEntity, object>> navigationProperty in includes)
                query = query.Include(navigationProperty);

            return query.Select(selector).ToListAsync();
        }

        public Task<List<TEntity>> PaginateAsync(int page, int count, out int total)
        {
            var query = context.Set<TEntity>();

            total = query.CountAsync().Result;
            return query.Skip(page * count).Take(count).ToListAsync();
        }

        public Task<List<TEntity>> PaginateAsync(int page, int count, out int total, bool asNoTracking = false)
        {
            var query = !asNoTracking ? context.Set<TEntity>() : context.Set<TEntity>().AsNoTracking();

            total = query.CountAsync().Result;
            return query.Skip(page * count).Take(count).ToListAsync();
        }

        public Task<List<TEntity>> PaginateAsync(int page, int count, out int total, Expression<Func<TEntity, bool>> predicate)
        {
            var query = context.Set<TEntity>().Where(predicate);

            total = query.CountAsync().Result;
            return query.Skip(page * count).Take(count).ToListAsync();
        }

        public Task<List<TEntity>> PaginateAsync(int page, int count, out int total, params Expression<Func<TEntity, object>>[] includes)
        {
            var query = (IQueryable<TEntity>)context.Set<TEntity>();

            //Apply eager loading
            foreach (Expression<Func<TEntity, object>> navigationProperty in includes)
                query = query.Include(navigationProperty);

            total = query.CountAsync().Result;
            return query.Skip(page * count).Take(count).ToListAsync();
        }

        public Task<List<TEntity>> PaginateAsync(int page, int count, out int total, Expression<Func<TEntity, bool>> predicate, bool asNoTracking = false)
        {
            var query = !asNoTracking ? context.Set<TEntity>().Where(predicate) : context.Set<TEntity>().Where(predicate).AsNoTracking();

            total = query.CountAsync().Result;
            return query.Skip(page * count).Take(count).ToListAsync();
        }

        public Task<List<TEntity>> PaginateAsync(int page, int count, out int total, Expression<Func<TEntity, bool>> predicate, params Expression<Func<TEntity, object>>[] includes)
        {
            var query = context.Set<TEntity>().Where(predicate);

            //Apply eager loading
            foreach (Expression<Func<TEntity, object>> navigationProperty in includes)
                query = query.Include(navigationProperty);

            total = query.CountAsync().Result;
            return query.Skip(page * count).Take(count).ToListAsync();
        }

        public Task<List<TEntity>> PaginateAsync(int page, int count, out int total, bool asNoTracking = false, params Expression<Func<TEntity, object>>[] includes)
        {
            var query = (IQueryable<TEntity>)context.Set<TEntity>();

            //Apply eager loading
            foreach (Expression<Func<TEntity, object>> navigationProperty in includes)
                query = query.Include(navigationProperty);

            query = !asNoTracking ? query : query.AsNoTracking();

            total = query.CountAsync().Result;
            return query.Skip(page * count).Take(count).ToListAsync();
        }

        public Task<List<TEntity>> PaginateAsync(int page, int count, out int total, Expression<Func<TEntity, bool>> predicate, bool asNoTracking = false, params Expression<Func<TEntity, object>>[] includes)
        {
            var query = context.Set<TEntity>().Where(predicate);

            //Apply eager loading
            foreach (Expression<Func<TEntity, object>> navigationProperty in includes)
                query = query.Include(navigationProperty);

            query = !asNoTracking ? query : query.AsNoTracking();

            total = query.CountAsync().Result;
            return query.Skip(page * count).Take(count).ToListAsync();
        }

        public Task<List<TSelect>> PaginateAsync<TSelect>(int page, int count, out int total, Expression<Func<TEntity, TSelect>> selector)
        {
            var query = context.Set<TEntity>().Select(selector);

            total = query.CountAsync().Result;
            return query.Skip(page * count).Take(count).ToListAsync();
        }

        public Task<List<TSelect>> PaginateAsync<TSelect>(int page, int count, out int total, Expression<Func<TEntity, bool>> predicate, Expression<Func<TEntity, TSelect>> selector)
        {
            var query = context.Set<TEntity>().Where(predicate).Select(selector);

            total = query.CountAsync().Result;
            return query.Skip(page * count).Take(count).ToListAsync();
        }

        public Task<List<TSelect>> PaginateAsync<TSelect>(int page, int count, out int total, Expression<Func<TEntity, TSelect>> selector, params Expression<Func<TEntity, object>>[] includes)
        {
            var query = (IQueryable<TEntity>)context.Set<TEntity>();

            //Apply eager loading
            foreach (Expression<Func<TEntity, object>> navigationProperty in includes)
                query = query.Include(navigationProperty);

            var selectedQuery = query.Select(selector);

            total = selectedQuery.CountAsync().Result;
            return selectedQuery.Skip(page * count).Take(count).ToListAsync();
        }

        public Task<List<TSelect>> PaginateAsync<TSelect>(int page, int count, out int total, Expression<Func<TEntity, bool>> predicate, Expression<Func<TEntity, TSelect>> selector, params Expression<Func<TEntity, object>>[] includes)
        {
            var query = context.Set<TEntity>().Where(predicate);

            //Apply eager loading
            foreach (Expression<Func<TEntity, object>> navigationProperty in includes)
                query = query.Include(navigationProperty);

            var selectedQuery = query.Select(selector);

            total = selectedQuery.CountAsync().Result;
            return selectedQuery.Skip(page * count).Take(count).ToListAsync();
        }
    }
}
