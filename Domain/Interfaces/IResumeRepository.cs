using Persistence.Models;

namespace Domain.Interfaces;

public interface IResumeRepository
{
    Task<Resume?> Get(Guid profileResumeId);
    Task Create(Resume newResume);
    Task Delete(Resume resumeToBeDeleted);
    Task Delete(Guid id);

}