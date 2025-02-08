using System.Threading.Tasks;

public interface IWeChatService
{
    Task<bool> ValidateSignatureAsync(UserConfiguration config, string echoStr);
    Task<string> GetAccessTokenAsync(UserConfiguration config);
}