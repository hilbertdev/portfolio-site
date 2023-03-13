using Domain.Dto;
using Persistence.Models;

namespace Domain.Interfaces;

public interface ISkillService
{
    Task AddSkill(Skill skill);
    Task<Skill?> GetSkill(Guid id);
    void UpdateSkill(Skill skill);
    Task<IEnumerable<Skill>> GetSkills();
}