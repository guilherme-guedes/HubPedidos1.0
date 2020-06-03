using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace HubPedidos.v1.Data.Repository
{
public interface IRepository<T> where T : class
{
        IEnumerable<T> Get();        
        Task<List<T>> GetAsync();
        IEnumerable<T> Get(Expression<Func<T, bool>> predicate);
        Task<List<T>> GetAsync(Expression<Func<T, bool>> predicate);
        void Add(T entity);
        void AddAsync(T entity);
        void Delete(T entity);
        void DeleteAsync(T entity);
        void Update(T entity);
}
}