using System;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

public class WeChatServiceImpl : IWeChatService
{
    private readonly IHttpClientFactory _httpClientFactory;
    private readonly IRedisCache _redisCache;
    private readonly ILogger<WeChatServiceImpl> _logger;

    // 使用构造函数注入 IHttpClientFactory 和其他依赖项
    public WeChatServiceImpl(IHttpClientFactory httpClientFactory, IRedisCache redisCache, ILogger<WeChatServiceImpl> logger)
    {
        _httpClientFactory = httpClientFactory ?? throw new ArgumentNullException(nameof(httpClientFactory));
        _redisCache = redisCache ?? throw new ArgumentNullException(nameof(redisCache));
        _logger = logger ?? throw new ArgumentNullException(nameof(logger));
    }

    public async Task<bool> ValidateSignatureAsync(UserConfiguration config, string echoStr)
    {
        try
        {
            // 实现签名验证逻辑...
            return true; // 示例中总是返回 true，请替换为实际的验证逻辑
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "签名验证失败");
            throw;
        }
    }

    public async Task<string> GetAccessTokenAsync(UserConfiguration config)
    {
        var cacheKey = $"wechat:access_token:{config.UserId}";

        try
        {
            // 尝试从 Redis 获取 access_token
            var cachedToken = await _redisCache.GetStringAsync(cacheKey);
            if (!string.IsNullOrEmpty(cachedToken))
            {
                _logger.LogInformation("从缓存获取了 access_token");
                return cachedToken;
            }

            // 如果缓存中没有，则向微信服务器请求新的 access_token
            var client = _httpClientFactory.CreateClient("WeChatApi"); // 使用命名客户端
            var url = $"https://api.weixin.qq.com/cgi-bin/token?grant_type=client_credential&appid={config.AppId}&secret={config.AppSecret}";
            HttpResponseMessage response = await client.GetAsync(url);
            response.EnsureSuccessStatusCode();
            string responseBody = await response.Content.ReadAsStringAsync();
            dynamic json = JObject.Parse(responseBody);

            if (json.errcode != null && json.errmsg != null)
            {
                _logger.LogError($"微信API错误: {json.errcode}, {json.errmsg}");
                throw new Exception($"微信API错误: {json.errcode}, {json.errmsg}");
            }

            string accessToken = json.access_token;
            await _redisCache.SetStringAsync(cacheKey, accessToken, TimeSpan.FromHours(2));

            _logger.LogInformation("成功获取并缓存了新的 access_token");
            return accessToken;
        }
        catch (HttpRequestException httpEx)
        {
            _logger.LogError(httpEx, "HTTP 请求错误");
            throw;
        }
        catch (JsonReaderException jsonEx)
        {
            _logger.LogError(jsonEx, "JSON 解析错误");
            throw;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "获取 access_token 时发生未知错误");
            throw;
        }
    }
}