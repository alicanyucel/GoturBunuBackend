using GoturBunu.Application.Services;
using Microsoft.EntityFrameworkCore;

namespace GoturBunu.Persistance.Services
{
    public class UnitOfWork<TContext> : IUnitOfWork where TContext : DbContext
    {
        protected readonly TContext context;
        public UnitOfWork(TContext context) => this.context = context;

        public void Dispose() => context.Dispose();

        public Task SaveChangesAsync() => context.SaveChangesAsync();
    }
}
