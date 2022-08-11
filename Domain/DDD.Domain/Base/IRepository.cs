using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Domain.Base
{
    public interface IRepository<T> where T : BaseEntity
    {
        IUnitOfWork UnitOfWork { get; }

        //Task<T> GetById(string id, bool includeDeleted = false);
        //Task<List<T>> GetAll(Expression<Func<T, bool>> expression, bool includeDeleted = false);
        //Task<string> Create(T entity);
        //Task<string[]> CreateRange(params T[] entities);
        //Task Update(T entity);
        //Task Delete(string id);

        Task<T> GetByIdAsync(string id, bool includeDeleted = false, CancellationToken token = default);
        Task<List<T>> GetAllAsync(Expression<Func<T, bool>> expression, bool includeDeleted = false, CancellationToken token = default);

        Task<string> CreateAsync(T entity, CancellationToken token = default);
        Task<string[]> CreateRangeAsync(params T[] entities);

        Task UpdateAsync(T entity, CancellationToken token = default);
        Task UpdateAsync(T entity, params Expression<Func<T, object>>[] changedProperties);

        Task DeleteAsync(string id, bool isPhysical = false, CancellationToken token = default);
    }
}
