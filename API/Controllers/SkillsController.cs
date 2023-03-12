using Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Persistence;
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
}
