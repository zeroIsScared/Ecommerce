﻿

using Ecommerce.Application.Interfaces;
using Ecommerce.Infrastructure;

namespace Ecommerce.Infrastracture
{
    public class UnitOfWork : IUnitOfWork 
    {
        private readonly EcommerceDBContext _context;

        public UnitOfWork(EcommerceDBContext context)
        {
            _context = context;
        }    

        public async Task SaveAsync(CancellationToken cancellationToken)
        {
            await _context.SaveChangesAsync(cancellationToken);
        }
        public async Task BeginTransactionAsync(CancellationToken cancellationToken)
        {
            await _context.Database.BeginTransactionAsync(cancellationToken);
        }
        public async Task CommitTransactionAsync(CancellationToken cancellationToken)
        {
           await _context.Database.CommitTransactionAsync(cancellationToken);
        }
        public async Task RollBackAsync(CancellationToken cancellationToken)
        {
            await _context.Database.RollbackTransactionAsync(cancellationToken);
        }
    }
}
