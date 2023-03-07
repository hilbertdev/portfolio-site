namespace Persistence.Models;

public class Reference
{
    public Guid Id { get; set; }
    public string? Name { get; set; }
    public string? Surname { get; set; }
    public string? Relationship { get; set; }
    public ContactDetail? ContactDetail { get; set; }
}