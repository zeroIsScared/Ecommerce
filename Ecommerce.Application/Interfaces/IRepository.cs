

using Ecommerce.Domain.Entities;

namespace Ecommerce.Application.Interfaces
{
 public interface IRepository<T> where T: class
    {
        T GetById(int id);
        T Add(T entity);
        void Remove(int Id);
        IQueryable<T> GetAll(int pageNumber, int pageSize);
        IQueryable<T> Read(bool track = false, bool isDeleted = false);
        T Update(T entity);
    }
}
