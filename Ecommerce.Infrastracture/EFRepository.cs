﻿

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

        public T Add(T entity)
        {
            _context.Set<T>().Add(entity);
            _context.SaveChanges();
            return entity;       
        }

        public IQueryable<T> GetAll(int pageNumber, int pageSize)
        {
            return _context.Set<T>()
                .Skip((pageNumber - 1) * pageSize)
                .Take(pageSize);                           
        }

        public IQueryable<T> GetById(int id) => _context.Set<T>().Where(x => x.Id == id);

        public IQueryable<T> Read(bool track = false)
        {
            var query = _context.Set<T>().AsQueryable();
            return track ? query : query.AsNoTracking();
        }

        public void Remove(T entity)
        {                     
            _context.Set<T>().Remove(entity);
            _context.SaveChanges();            
        }

        public void Update(T entity)
        {           
            _context.Entry(entity).State = EntityState.Modified;
            _context.SaveChanges();            
        }

      
    }
}
