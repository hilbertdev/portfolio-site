using Application.Interfaces;
using Persistence.Models;

namespace Application.Services;

public class HomePageService : IHomePageService
{
    private readonly IResumeRepository _resumeRepository;

    public HomePageService(IResumeRepository resumeRepository)
    {
        _resumeRepository = resumeRepository;
    }
    public async Task<Resume?> LoadProfileResume(Guid profileResumeId)
    {
        return await _resumeRepository.GetResumeByProfileId(profileResumeId);
    }

    public async Task AddNewProfileResume(Resume profileResume)
    {
        await _resumeRepository.AddProfileResume(profileResume);
    }
}