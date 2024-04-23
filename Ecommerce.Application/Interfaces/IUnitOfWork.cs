

using Ecommerce.Domain.Entities;

namespace Ecommerce.Application.Interfaces
{
    public interface IUnitOfWork
    {
        Task SaveAsync();
        Task BeginTransactionAsync();
        Task CommitTransactionAsync();
        Task RollBackAsync();
    }
}
