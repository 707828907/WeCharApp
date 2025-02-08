using Microsoft.EntityFrameworkCore;

public class UserRepository : IUserRepository
{
    private readonly ApplicationDbContext _context;

    public UserRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<UserConfiguration> GetUserConfigurationAsync(string userId)
    {
        return await _context.UserConfigurations.FindAsync(userId);
    }

    public async Task AddOrUpdateUserConfigurationAsync(UserConfiguration config)
    {
        var existing = await _context.UserConfigurations.FindAsync(config.UserId);
        if (existing != null)
        {
            _context.Entry(existing).CurrentValues.SetValues(config);
        }
        else
        {
            _context.UserConfigurations.Add(config);
        }
        await _context.SaveChangesAsync();
    }
}