using System.ComponentModel.DataAnnotations;

public class UserConfiguration
{
    [Key]
    public string UserId { get; set; }
    public string AppId { get; set; }
    public string AppSecret { get; set; }
    public string Token { get; set; }
}