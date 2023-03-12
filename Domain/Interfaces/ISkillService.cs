using Persistence.Models;

namespace Domain.Interfaces;

public interface ISkillService
{
    Task AddSkill(Skill skill);
}