// WeChatDataAccess/UserConfiguration.cs
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

public class UserConfiguration
{
    [Key]
    public required string UserId { get; set; }
    public required string AppId { get; set; }
    public required string AppSecret { get; set; }
    public required string Token { get; set; }
}

// WeChatDataAccess/ApplicationDbContext.cs
public class ApplicationDbContext : DbContext
{
    public DbSet<UserConfiguration> UserConfigurations { get; set; }

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }
}