using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using service.API.Services;
using service.API.Models;

namespace service.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class PoolController : ControllerBase
{
    private readonly IPoolService _poolService;

    public PoolController(IPoolService poolService)
    {
        _poolService = poolService;
    }


    [HttpGet]
    public async Task<ActionResult<IEnumerable<Pool>>> GetAllPoolsAsync()
    {
        var pools = await _poolService.GettAllPoolsAsyncs();
        return Ok(pools);
        
    }

    [HttpPost]
    public async Task<ActionResult<Pool>> PostPoolAsync(Pool pool)
    {
        await _poolService.CreatePoolAsync(pool);
        return Ok(pool);
    }

    [HttpPut("{id}")]
    public async Task<ActionResult<Pool>> PutPoolAsync(int id, Pool pool)
    {
        if(id != pool.Id) return BadRequest();

        var poolUpdate = await _poolService.UpdatePoolAsync(pool);
        if (poolUpdate ==  null) return NotFound();

        return Ok(poolUpdate);
    }
}