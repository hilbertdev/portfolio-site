using Persistence.Models;

namespace Application.Interfaces;

public interface IHomePageService
{
    Task<Resume?> LoadProfileResume(Guid profileResumeId);

    Task AddNewProfileResume(Resume profileResume);
}