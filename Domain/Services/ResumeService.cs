using Domain.Interfaces;
using Persistence.Models;

namespace Domain.Services;

public class ResumeService : IResumeService
{
    private readonly IResumeRepository _resumeRepository;
    public ResumeService(IResumeRepository resumeRepository)
    {
        _resumeRepository = resumeRepository;
    }
    public async Task<Resume?> LoadProfileResume(Guid profileResumeId)
    {
        return await _resumeRepository.Get(profileResumeId);
    }

    public async Task AddNewProfileResume(Resume profileResume)
    {
        await _resumeRepository.Create(profileResume);
    }
}