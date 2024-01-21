using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoturBunu.Application.Services
{
    public interface IUnitOfWork : IDisposable
    {
        Task SaveChangesAsync();
    }
}
