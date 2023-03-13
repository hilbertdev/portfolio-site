using System.ComponentModel.DataAnnotations;

namespace Persistence.Models;

public class Profile
{
    [Key]
    public Guid Id { get; set; }

    public string? JobProfile { get; set; }

    public string? JobDescription { get; set; }
}