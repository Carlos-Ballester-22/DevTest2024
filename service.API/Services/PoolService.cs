using service.API.Models;
using service.API.Repository;

namespace service.API.Services;


public class PoolService : IPoolService
{    
    private readonly IPoolRepository _repository;

    public PoolService(IPoolRepository repository)
    {
        _repository = repository;
    }
    public async Task<IEnumerable<Pool>> GettAllPoolsAsyncs()
    {
        return await _repository.GetAllAsync();
    }


    public async Task<Pool> CreatePoolAsync(Pool pool)
    {
        await _repository.CreateAsync(pool);
        return pool;
    }

    public async Task<Pool> UpdatePoolAsync(Pool pool)
    {
        await _repository.UpdateAsync(pool);
        return pool;   
    }
}