using service.API.Repository;
using service.API.Services;

namespace service.API;

public static class Inject 
{
    public static void InjectDependences(this IServiceCollection services)
    {
        InjectRepository(services);
        InjectServices(services);
    }

    public static void InjectRepository(IServiceCollection services)
    {
        services.AddScoped<IPoolRepository, MemoryPoolRepository>(); //Memory

        // services.AddScoped<IPoolRepository, PoolRepository>(); //DB
    }

    public static void InjectServices(IServiceCollection services)
    {
        services.AddScoped<IPoolService, PoolService>();
    }
}