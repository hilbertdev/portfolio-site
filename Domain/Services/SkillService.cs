using Domain.Dto;
using Domain.Interfaces;
using Domain.Repositories;
using Persistence;
using Persistence.Models;

namespace Domain.Services;

public class SkillService : ISkillService
{
    private readonly GenericRepository<Skill> _skillRepository;
    private readonly Context _context;
    

    public SkillService(Context context)
    {
        _context = context;
        _skillRepository = new GenericRepository<Skill>(_context);
    }
    
    public async Task AddSkill(Skill skill)
    {
        await _skillRepository.Insert(skill);
    }

    public async Task<Skill?> GetSkill(Guid id)
    {
       var result = await _skillRepository.Get(filter: skill => skill.Id == id);
       return result.FirstOrDefault();
    }

    public void UpdateSkill(Skill skill)
    {
         _skillRepository.Update(skill);
    }

    public async Task<IEnumerable<Skill>> GetSkills()
    {
        return await _skillRepository.Get();
    }
}