using System.ComponentModel.DataAnnotations;

namespace Persistence.Models;

public class Skill
{
    [Key]
    public Guid Id { get; set; }
    public string? Name { get; set; }
    public string? Description { get; set; }
}