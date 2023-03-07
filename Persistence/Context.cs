using Microsoft.EntityFrameworkCore;
using Persistence.Models;

namespace Persistence;

public class Context : DbContext
{
    public DbSet<Resume> Resumes { get; set; }
    public DbSet<Skill> Skills { get; set; }
    public DbSet<Reference> References { get; set; }
    public DbSet<EducationHistory> EducationHistories { get; set; }
    public DbSet<ContactDetail> ContactDetails { get; set; }
    public DbSet<WorkHistory> WorkHistories { get; set; }
}