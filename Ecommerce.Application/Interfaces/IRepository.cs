

using Ecommerce.Domain.Entities;

namespace Ecommerce.Application.Interfaces
{
 public interface IRepository<T> where T: class
    {
        Task<bool> ExistsOrThrowsAsync(long id, CancellationToken cancellationToken = default); 
        Task<T> TryGetByIdOrThrowAsync(long id, CancellationToken cancellationToken = default);
        Task<T> AddAsync(T entity, CancellationToken cancellationToken = default);
        Task RemoveAsync(long id, CancellationToken cancellationToken = default);
        Task RemoveRangeAsync(List<T> removeList, CancellationToken cancellationToken = default);
        Task SoftRemoveAsync(long id, CancellationToken cancellationToken = default);
        Task SoftRemoveRangeAsync(List<T> removeList, CancellationToken cancellationToken = default);
        IQueryable<T> GetAll(int pageNumber, int pageSize);
        IQueryable<T> Read(bool track = false);
        Task<T> UpdateAsync(T entity, CancellationToken cancellationToken = default);
    }
}
