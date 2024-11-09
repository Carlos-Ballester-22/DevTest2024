using service.API.Models;

namespace service.API.Repository;

public class MemoryPoolRepository : IPoolRepository
{

    private readonly List<Pool> _pools = new List<Pool>();
    private int _nextId = 1;

    public Task<IEnumerable<Pool>> GetAllAsync()
    {
        return Task.FromResult<IEnumerable<Pool>>(_pools);
    }

    public Task CreateAsync(Pool pool)
    {
        pool.Id = _nextId++;
        _pools.Add(pool);
        return Task.CompletedTask;
    }

    public Task<Pool> UpdateAsync(Pool pool)
    {
        var exisingPool = _pools.FirstOrDefault(u => u.Id == pool.Id);
        if (exisingPool == null) return Task.FromResult(pool);

        exisingPool.Name = pool.Name;
        exisingPool.options = pool.options;

        return Task.FromResult(exisingPool);
    }
}