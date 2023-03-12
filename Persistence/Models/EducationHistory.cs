using System.ComponentModel.DataAnnotations;

namespace Persistence.Models;

public class EducationHistory
{
    [Key]
    public Guid Id { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public string? InstitutionName { get; set; }
    public string? QualificationName { get; set; }
}