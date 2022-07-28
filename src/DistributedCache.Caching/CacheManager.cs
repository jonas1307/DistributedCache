using DistributedCache.Caching.Contracts;
using DistributedCache.Caching.Utils;

namespace DistributedCache.Caching
{
    public class CacheManager : ICacheManager
    {
        private readonly ILocalCache _localCache;

        public CacheManager(ILocalCache localCache)
        {
            _localCache = localCache;
        }

        public T? Get<T>(string id)
        {
            var key = KeyUtil.GenerateKey<T>(id);

            return _localCache.Get<T>(key);
        }

        public void Set<T>(T value, string id, TimeSpan? expiration = null)
        {
            var key = KeyUtil.GenerateKey<T>(id);

            _localCache.Set<T>(value, key, expiration);
        }
    }
}