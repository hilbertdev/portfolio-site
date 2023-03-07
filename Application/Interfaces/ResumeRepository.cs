using Persistence.Models;

namespace Application.Interfaces;

public interface IResumeRepository
{
    Task<Resume> GetResumeByProfileId(Guid profileId);
}