using System.ComponentModel.DataAnnotations;

namespace Persistence.Models;

public class WorkHistory
{
    [Key]
    public Guid Id { get; set; }

    public bool IsCurrent { get; set; }

    public string? JobDescription { get; set; }

    public DateTime StartDate { get; set; }

    public DateTime EndDate { get; set; }
    
}