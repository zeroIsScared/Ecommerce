

using Ecommerce.Domain.Entities;

namespace Ecommerce.Application.Interfaces
{
    public interface IUnitOfWork
    {
        Task SaveAsync(CancellationToken cancellationToken = default);
        Task BeginTransactionAsync(CancellationToken cancellationToken = default);
        Task CommitTransactionAsync(CancellationToken cancellationToken = default);
        Task RollBackAsync(CancellationToken cancellationToken = default);
    }
}
