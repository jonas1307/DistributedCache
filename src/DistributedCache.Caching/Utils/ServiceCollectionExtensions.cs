using DistributedCache.Caching.Contracts;
using Microsoft.Extensions.DependencyInjection;

namespace DistributedCache.Caching.Utils
{
    public static class ServiceCollectionExtensions
    {
        public static void RegisterCachingServices(this IServiceCollection services)
        {
            services.AddTransient<ILocalCache, LocalCache>();
            services.AddTransient<ICacheManager, CacheManager>();
        }
    }
}