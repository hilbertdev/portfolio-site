using System.ComponentModel.DataAnnotations;

namespace Persistence.Models;

public class ContactDetail
{
    [Key]
    public Guid Id { get; set; }
    public string? Email { get; set; }
    public string? PhoneNumber { get; set; }
    public string? LinkedlnProfile { get; set; }
    public string? GithubRepo { get; set; }
    public string? WebsiteUrl { get; set; }
}