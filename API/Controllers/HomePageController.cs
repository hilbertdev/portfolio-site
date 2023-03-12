using Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Persistence.Models;

namespace API.Controllers;

[ApiController]
[Route("[controller]")]

public class HomePageController : ControllerBase
{
    private readonly IResumeService _resumeService;

    public HomePageController(IResumeService resumeService)
    {
        _resumeService = resumeService;
    }

    [HttpPost]
    [Route("AddProfileResume")]

    public async Task AddProfileResume(Resume profileResume)
    {
        await _resumeService.AddNewProfileResume(profileResume);
    }
    
    [HttpGet]
    [Route("LoadProfileResume")]
    public async Task<Resume?> LoadProfileResume(Guid profileId)
    {
        return await _resumeService.LoadProfileResume(profileId);
    }
}