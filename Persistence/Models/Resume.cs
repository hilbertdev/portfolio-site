

namespace Persistence.Models;

public class Resume
{
    public Guid Id { get; set; }
    public List<WorkHistory>? WorkHistories { get; set; }
    public List<Skill>? Skills { get; set; }
    public List<EducationHistory>? EducationHistories { get; set; }
    public List<Reference>? References { get; set; }
    public Guid? ProfileId { get; set; }
}