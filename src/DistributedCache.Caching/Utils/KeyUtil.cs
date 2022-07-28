namespace DistributedCache.Caching.Utils
{
    public static class KeyUtil
    {
        public static string GenerateKey<T>(string id)
        {
            return $"{typeof(T).FullName}_{id}".Replace(".", "_");
        }
    }
}
