using Domain.Interfaces;
using Persistence;
using Persistence.Models;

namespace Domain.Services;

public class SkillsRepository: ISkillRepository
{
    private readonly Context _context;

    public SkillsRepository(Context context)
    {
        _context = context;
    }
    public async Task Create(Skill skill)
    {
        await _context.Skills.AddAsync(skill);
        await _context.SaveChangesAsync();
    }
}