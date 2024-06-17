

using Ecommerce.Application.Exceptions;
using Ecommerce.Application.Interfaces;
using Ecommerce.Domain.Entities;
using Ecommerce.Infrastructure;
using Microsoft.EntityFrameworkCore;


namespace Ecommerce.Infrastracture
{
    public class EFRepository<T> : IRepository<T> where T : BaseEntity
    {
        private readonly EcommerceDBContext _context;

        public EFRepository(EcommerceDBContext context)
        {
            _context = context;
        }

        public async Task<bool> ExistsOrThrowsAsync(long id, CancellationToken cancellationToken = default)
        {
            var result = await _context.Set<T>().AnyAsync(x => x.Id == id, cancellationToken);

            if (result is false)
                throw new EntityNotFoundException(typeof(T), id);

            return true;
        }
        public async Task<T> AddAsync(T entity, CancellationToken cancellationToken = default)
        {
            await _context.Set<T>().AddAsync(entity, cancellationToken);
            await _context.SaveChangesAsync(cancellationToken);
            return entity;       
        }

        public IQueryable<T> GetAll(int pageNumber, int pageSize)
        {
            return _context.Set<T>()
                .Skip((pageNumber - 1) * pageSize)
                .Take(pageSize);                           
        }

        public IQueryable<T> Read( bool track = false )
        {
            var query = _context.Set<T>().AsQueryable();            
            return track ? query : query.AsNoTracking();
        }

        public async Task RemoveAsync(long id, CancellationToken cancellationToken = default)
        {
            var entity = await _context.Set<T>().FirstAsync(x => x.Id == id);
            _context.Set<T>().Remove(entity);
            await _context.SaveChangesAsync(cancellationToken);            
        }

        public async Task RemoveRangeAsync(IEnumerable<T> removeList, CancellationToken cancellationToken = default)
        {
            _context.Set<T>().RemoveRange(removeList);

            await _context.SaveChangesAsync(cancellationToken);
        }

        public async Task SoftRemoveAsync(long id, CancellationToken cancellationToken = default)
        {
            var entity =  _context.Set<T>().First(x => x.Id == id);
            entity.IsDeleted = true;
            await _context.SaveChangesAsync(cancellationToken);
        }

        public async Task SoftRemoveRangeAsync(IEnumerable<T> removeList, CancellationToken cancellationToken = default)
        {
            foreach (var item in removeList)
            {
                item.IsDeleted = true;
            }

            await _context.SaveChangesAsync(cancellationToken);
        }

        public async Task<T> UpdateAsync(T entity, CancellationToken cancellationToken = default)
        {   
            //var current = await _context.Set<T>().FirstAsync(x => x.Id == entity.Id);
           
           _context.Entry(entity).State = EntityState.Modified;
          
               // _context.Entry(current).CurrentValues.SetValues(entity);
                await _context.SaveChangesAsync(cancellationToken);
            
            
            return entity;
        }        

        public async Task<T> TryGetByIdOrThrowAsync(long id, CancellationToken cancellationToken = default) 
        {
            var entity = await _context.Set<T>().FirstOrDefaultAsync(x => x.Id == id, cancellationToken);

            if (entity == default)
                throw EntityNotFoundException.OfType<T>(id);

            return entity;
        }
    }
}
