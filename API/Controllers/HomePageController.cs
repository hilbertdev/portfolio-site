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
    
    [HttpGet]
    [Route("LoadProfileResume")]
    public async Task<Resume> LoadProfileResume(Guid profileId)
    {
        return await _homePageService.LoadProfileResume(profileId);
    }
}