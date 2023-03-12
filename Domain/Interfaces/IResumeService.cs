using Persistence.Models;

namespace Domain.Interfaces;

public interface IResumeService
{
    Task<Resume?> LoadProfileResume(Guid profileResumeId);

    Task AddNewProfileResume(Resume profileResume);
}