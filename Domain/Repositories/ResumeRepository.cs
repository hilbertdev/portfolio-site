using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using Persistence;
using Persistence.Models;

namespace Domain.Repositories;

public class ResumeRepository: IResumeRepository
{
    private readonly Context _context;

    public ResumeRepository(Context context)
    {
        _context = context;
    }
    public async Task<Resume?> Get(Guid profileResumeId)
    {
        return await _context.Resumes.Include(x => x.Skills).FirstOrDefaultAsync(x => x.ProfileId == profileResumeId);
    }

    public async Task Create(Resume newResume)
    {
        await _context.AddAsync(newResume);
        await _context.SaveChangesAsync();
    }

    public async Task Delete(Resume resumeToBeDeleted)
    {
         _context.Resumes.Remove(resumeToBeDeleted);
         await _context.SaveChangesAsync();
    }

    public async Task Delete(Guid id)
    {
        var resume = await _context.Resumes.FirstOrDefaultAsync();
        if (resume != null)
        {
            _context.Resumes.Remove(resume);
            await _context.SaveChangesAsync();
        }
    }
}