using service.API.Models;

namespace service.API.Services;


public interface IPoolService
{
    Task<IEnumerable<Pool>> GettAllPoolsAsyncs();

    Task<Pool> CreatePoolAsync(Pool pool);

    Task<Pool> UpdatePoolAsync(Pool pool);
}