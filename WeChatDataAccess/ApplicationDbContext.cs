// WeChatDataAccess/ApplicationDbContext.cs
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
// WeChatDataAccess/UserConfiguration.cs

namespace WeChatDataAccess
{
    public class UserConfiguration
    {
        public required string UserId { get; set; }
        public required string AppId { get; set; }
        public required string AppSecret { get; set; }
        public required string Token { get; set; }
    }
}
