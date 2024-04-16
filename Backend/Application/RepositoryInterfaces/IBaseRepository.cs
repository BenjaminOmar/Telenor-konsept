using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public interface IBaseRepository<T> where T : class
    {
        Task Add(T entity);
        Task<IEnumerable<T>> GetAll();
        Task<T> GetById(Guid id);
        Task Update(T entity);
        Task Delete(T entity);
        Task SaveChanges();
    }
}
