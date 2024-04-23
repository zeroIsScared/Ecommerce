

using Ecommerce.Application.Interfaces;
using Ecommerce.Infrastructure;

namespace Ecommerce.Infrastracture
{
    public class UnitOfWork: IUnitOfWork 
    {
        private readonly EcommerceDBContext _context;

        public UnitOfWork(EcommerceDBContext context)
        {
            _context = context;
        }    

        public async Task SaveAsync()
        {
            await _context.SaveChangesAsync();
        }
        public async Task BeginTransactionAsync()
        {
            await _context.Database.BeginTransactionAsync();
        }
        public async Task CommitTransactionAsync()
        {
           await _context.Database.CommitTransactionAsync();
        }
        public async Task RollBackAsync()
        {
            await _context.Database.RollbackTransactionAsync();
        }
    }
}
