using Application.Interfaces;
using Microsoft.EntityFrameworkCore;
using Persistence;
using Persistence.Models;

namespace Application.Repositories;

public class ResumeRepository: IResumeRepository
{
    private readonly Context _context;

    public ResumeRepository(Context context)
    {
        _context = context;
    }
    public async Task<Resume?> GetResumeByProfileId(Guid profileId)
    {
        return await _context.Resumes.FirstOrDefaultAsync(x => x.ProfileId == profileId);
    }

    public async Task AddProfileResume(Resume profileResume)
    {
        await _context.Resumes.AddAsync(profileResume);
        await _context.SaveChangesAsync();
    }

    public Task<Resume?> Get(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task<Resume> Update(Resume resumeUpdates)
    {
        throw new NotImplementedException();
    }

    public Task Delete(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task Create(Resume newResume)
    {
        throw new NotImplementedException();
    }
}