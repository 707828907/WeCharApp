public interface IRedisCache
{
    Task<string> GetStringAsync(string key);
    Task SetStringAsync(string key, string value, TimeSpan? expiration = null);
}