using Persistence.Models;

namespace Domain.Interfaces;

public interface ISkillRepository
{
    Task Create(Skill skill);
}