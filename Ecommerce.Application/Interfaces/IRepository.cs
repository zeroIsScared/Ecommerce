

using Ecommerce.Domain.Entities;

namespace Ecommerce.Application.Interfaces
{
 public interface IRepository<T> where T: BaseEntity
    {
        IQueryable<T> GetById(int id);
        T Add(T entity);
        void Remove(T entity);
        IQueryable<T> GetAll(int pageNumber, int pageSize);
        IQueryable<T> Read(bool track = false);
        void Update(T entity);
    }
}
