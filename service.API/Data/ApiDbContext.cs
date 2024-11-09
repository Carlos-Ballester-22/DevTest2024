using Microsoft.EntityFrameworkCore;
using service.API.Models;

namespace service.API.Data;



public class ApiDbContext : DbContext
{
    public ApiDbContext(DbContextOptions<ApiDbContext> options) : base(options)
    {
        
    }

    public DbSet<Pool> Pools{ get; set; }
}