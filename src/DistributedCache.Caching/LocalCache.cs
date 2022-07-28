using DistributedCache.Caching.Contracts;
using Microsoft.Extensions.Caching.Memory;

namespace DistributedCache.Caching
{
    public class LocalCache : ILocalCache
    {
        private readonly IMemoryCache _cache;
        private readonly TimeSpan DefaultExpiration = TimeSpan.FromMinutes(5);

        public LocalCache(IMemoryCache memoryCache)
        {
            _cache = memoryCache;
        }

        public T? Get<T>(string id)
        {
            if (string.IsNullOrEmpty(id)) return default;

            if (_cache.TryGetValue(id, out T value)) return value;

            return default;
        }

        public bool Set<T>(T value, string id, TimeSpan? expiration = null)
        {
            if (value is null) return false;

            _cache.Set<T>(id, value, expiration ?? DefaultExpiration);

            return true;
        }

        public bool Remove(string id)
        {
            _cache.Remove(id);

            return true;
        }
    }
}
