using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HubPedidos.v1.Data.Transaction;
using Microsoft.EntityFrameworkCore;

namespace HubPedidos.v1.Data.Repositories
{
    public class BaseRepository<T> : IRepository<T> where T : class
    {
       private readonly IUnitOfWork _unitOfWork;
        public BaseRepository(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public void Add(T entity)
        {
            _unitOfWork.Context.Set<T>().Add(entity);
        }
        
        public void AddAsync(T entity)
        {
            _unitOfWork.Context.Set<T>().AddAsync(entity);
        }
 
        public void Delete(T entity)
        {
            T existing = _unitOfWork.Context.Set<T>().Find(entity);
            if (existing != null) _unitOfWork.Context.Set<T>().Remove(existing);
        }
        public void DeleteAsync(T entity)
        {
            ValueTask<T> existing = _unitOfWork.Context.Set<T>().FindAsync(entity);
            if (existing != null && existing.IsCompleted) _unitOfWork.Context.Set<T>().Remove(existing.Result);
        }
 
        public IEnumerable<T> Get()
        {
            return _unitOfWork.Context.Set<T>().AsEnumerable<T>();
        }
 
        public Task<List<T>> GetAsync()
        {
            return _unitOfWork.Context.Set<T>().ToListAsync<T>();
        }

        public IEnumerable<T> Get(System.Linq.Expressions.Expression<Func<T, bool>> predicate)
        {
            return _unitOfWork.Context.Set<T>().Where(predicate).AsEnumerable<T>();
        }
        
        public Task<List<T>> GetAsync(System.Linq.Expressions.Expression<Func<T, bool>> predicate)
        {
            return _unitOfWork.Context.Set<T>().Where(predicate).ToListAsync<T>();
        }
 
        public void Update(T entity)
        {
            _unitOfWork.Context.Entry(entity).State = EntityState.Modified;
            _unitOfWork.Context.Set<T>().Attach(entity);
        }
    }
}