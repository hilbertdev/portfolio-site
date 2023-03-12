using Persistence.Models;

namespace Application.Interfaces;

public interface IResumeRepository
{
    Task<Resume?> GetResumeByProfileId(Guid profileId);
    Task AddProfileResume(Resume profileResume);
    Task<Resume?> Get(Guid id);
    Task<Resume> Update(Resume resumeUpdates);
    Task Delete(Guid id);
    Task Create(Resume newResume);
}