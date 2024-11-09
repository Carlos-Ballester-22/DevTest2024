using service.API.Models;
using service.API.Data;
using Microsoft.EntityFrameworkCore;

namespace service.API.Repository;


public class PoolRepository : IPoolRepository
{
    private readonly ApiDbContext _dbContext;

    public PoolRepository(ApiDbContext dbContext)
    {
        _dbContext = dbContext;
    }
    public async Task<IEnumerable<Pool>> GetAllAsync() => await _dbContext.Pools.ToListAsync();

    public async Task CreateAsync(Pool pool)
    {
        await _dbContext.Pools.AddAsync(pool);
        await _dbContext.SaveChangesAsync();
    }

    public async Task<Pool> UpdateAsync(Pool pool)
    {
        _dbContext.Entry(pool).State = EntityState.Modified;
        try{
            await _dbContext.SaveChangesAsync();
            return pool;
        }
        catch
        {
            return null;
        }

    }
}