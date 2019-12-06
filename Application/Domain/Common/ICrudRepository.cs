using System.Collections.Generic;
using System.Threading.Tasks;

namespace FootballApi.Domain.Common
{
    public interface ICrudRepository<T>
        where T: Entity
    {
        Task<T> GetByIdAsync(string id);
        Task<IEnumerable<T>> GetAll();
        Task AddAsync(T customer);
        Task UpdateAsync(T customer);
        Task DeleteAsync(T customer);
    }
}