namespace Rcon.Core.Repositories
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public interface IBaseRepository<TEntity, in TKey> where TEntity : class
    {
        Task<IEnumerable<TEntity>> GetAllAsync();

        Task<TEntity> GetAsync(TKey _key);

        Task AddAsync(TEntity _entity);

        Task UpdateAsync(TEntity _entity);

        Task RemoveAsync(TKey _key);
    }
}
