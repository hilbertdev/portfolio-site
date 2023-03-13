using Domain.Interfaces;
using Domain.Repositories;
using Persistence;
using Persistence.Models;

namespace Domain.Services;

public class ResumeService : IResumeService
{
    private readonly GenericRepository<Resume> _resumeRepository;
    private readonly Context _context;

    public ResumeService(Context context)
    {
        _context = context;
        _resumeRepository = new GenericRepository<Resume>(_context);
    }
    public async Task<Resume?> LoadProfileResume(Guid profileResumeId)
    {
        var result = await _resumeRepository.Get(filter: resume => resume.ProfileId == profileResumeId);
        return result.FirstOrDefault();
    }

    public async Task AddNewProfileResume(Resume profileResume)
    {
        await _resumeRepository.Insert(profileResume);
    }
}