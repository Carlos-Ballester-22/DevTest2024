using service.API.Models;

namespace service.API.Repository;

public interface IPoolRepository
{
    Task<IEnumerable<Pool>> GetAllAsync();

    Task CreateAsync(Pool pool);

    Task<Pool> UpdateAsync(Pool pool);
}