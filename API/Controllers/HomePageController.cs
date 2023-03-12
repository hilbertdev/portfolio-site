using Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Persistence.Models;

namespace API.Controllers;

[ApiController]
[Route("[controller]")]

public class HomePageController : ControllerBase
{
    private readonly IHomePageService _homePageService;

    public HomePageController(IHomePageService homePageService)
    {
        _homePageService = homePageService;
    }

    [HttpPost]
    [Route("AddProfileResume")]

    public async Task AddProfileResume(Resume profileResume)
    {
        await _homePageService.AddNewProfileResume(profileResume);
    }
    
    [HttpGet]
    [Route("LoadProfileResume")]
    public async Task<Resume?> LoadProfileResume(Guid profileId)
    {
        return await _homePageService.LoadProfileResume(profileId);
    }
}