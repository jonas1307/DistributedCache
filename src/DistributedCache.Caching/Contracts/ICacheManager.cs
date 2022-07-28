namespace DistributedCache.Caching.Contracts
{
    public interface ICacheManager
    {
        T? Get<T>(string id);
        void Set<T>(T value, string id, TimeSpan? expiration = null);
    }
}