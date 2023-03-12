using Domain.Interfaces;
using Persistence.Models;

namespace Domain.Services;

public class SkillService : ISkillService
{
    private readonly ISkillRepository _skillRepository;

    public SkillService(ISkillRepository skillRepository)
    {
        _skillRepository = skillRepository;
    }
    
    public async Task AddSkill(Skill skill)
    {
        await _skillRepository.Create(skill);
    }
}