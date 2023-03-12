using System.ComponentModel.DataAnnotations;

namespace Persistence.Models;

public class Reference
{
    [Key]
    public Guid Id { get; set; }
    public string? Name { get; set; }
    public string? Surname { get; set; }
    public string? Relationship { get; set; }
    public ContactDetail? ContactDetail { get; set; }
}