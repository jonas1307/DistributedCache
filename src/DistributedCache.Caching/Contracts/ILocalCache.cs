namespace DistributedCache.Caching.Contracts
{
    public interface ILocalCache
    {
        T? Get<T>(string id);
        bool Set<T>(T value, string id, TimeSpan? expiration = null);
        bool Remove(string id);
    }
}