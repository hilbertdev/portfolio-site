using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using Persistence;
using Persistence.Models;

namespace Domain.Services;

public class ResumeService : IResumeService
{
    private readonly Context _context;
    public ResumeService(Context context)
    {
        _context = context;
    }
    public async Task<Resume?> LoadProfileResume(Guid profileResumeId)
    {
        return await _context.Resumes.FirstOrDefaultAsync(x => x.ProfileId == profileResumeId);
    }

    public async Task AddNewProfileResume(Resume profileResume)
    {
        await  _context.Resumes.AddAsync(profileResume);
        await _context.SaveChangesAsync();
    }
}