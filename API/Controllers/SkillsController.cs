using Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Persistence.Models;

namespace API.Controllers;

[ApiController]
[Route("[controller]")]

public class SkillsController : ControllerBase
{
    private readonly ISkillService _skillService;
    
    public SkillsController(ISkillService skillService)
    {
        _skillService = skillService;
    }
    
    [HttpPost]
    [Route("AddSkill")]

    public async Task AddSkill(Skill skill)
    {
        await _skillService.AddSkill(skill);
    }
    
    [HttpPost]
    [Route("UpdateSkill")]
    public async Task UpdateSkill(Skill skill)
    {
       await Task.Run(() => _skillService.UpdateSkill(skill));
    }

    [HttpGet]
    [Route("GetSkill")]
    public async Task<Skill?> GetSkill(Guid id)
    {
        return await _skillService.GetSkill(id);
    }
    
    [HttpGet]
    [Route("GetSkill")]
    public async Task<IEnumerable<Skill>> GetSkills()
    {
       return await Task.Run(() =>_skillService.GetSkills());
    }
}
