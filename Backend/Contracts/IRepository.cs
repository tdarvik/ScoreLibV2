using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Contracts
{
    public interface IRepository<TEntity> where TEntity : class
    {
        Task<TEntity> GetAsync(object id);
        Task<IEnumerable<TEntity>> GetAllAsync();
        void Add(TEntity entity);
        void AddMany(IEnumerable<TEntity> entities);
        void Remove(object id);
        void RemoveMany(List<object> ids);
        void Update(TEntity entity);
    }
}
