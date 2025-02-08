public interface IUserRepository
{
    Task<UserConfiguration> GetUserConfigurationAsync(string userId);
    Task AddOrUpdateUserConfigurationAsync(UserConfiguration config);
}