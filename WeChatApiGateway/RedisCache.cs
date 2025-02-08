using StackExchange.Redis;

public class RedisCache : IRedisCache
{
    private readonly ConnectionMultiplexer _connection;
    private readonly IDatabase _database;

    public RedisCache()
    {
        _connection = ConnectionMultiplexer.Connect("your_redis_connection_string");
        _database = _connection.GetDatabase();
    }

    public async Task<string> GetStringAsync(string key)
    {
        return await _database.StringGetAsync(key);
    }

    public async Task SetStringAsync(string key, string value, TimeSpan? expiration = null)
    {
        await _database.StringSetAsync(key, value, expiration);
    }
}