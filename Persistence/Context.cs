using Microsoft.EntityFrameworkCore;
using Persistence.Models;

namespace Persistence;

public class Context : DbContext
{
    public Context(DbContextOptions<Context> options): base(options)
    {
        
    }
    public DbSet<Resume> Resumes { get; set; }
    public DbSet<Skill> Skills { get; set; }
    public DbSet<Reference> References { get; set; }
    public DbSet<EducationHistory> EducationHistories { get; set; }
    public DbSet<ContactDetail> ContactDetails { get; set; }
    public DbSet<WorkHistory> WorkHistories { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Resume>()
            .HasMany(x => x.Skills);
        modelBuilder.Entity<Resume>().HasMany(x => x.References);
        modelBuilder.Entity<Resume>().HasMany(x => x.WorkHistories);
        modelBuilder.Entity<Resume>().HasOne(x => x.ContactDetail);
        modelBuilder.Entity<Resume>().HasMany(x => x.EducationHistories);
        modelBuilder.Entity<Resume>().HasKey(x => x.ProfileId);



    }
}