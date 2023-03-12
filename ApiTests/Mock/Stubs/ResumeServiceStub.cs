using Domain.Interfaces;
using Domain.Services;
using Moq;

namespace HomePageServiceTests.Mock.Stubs;

public class ResumeServiceStub
{
    private readonly Mock<IResumeRepository> _resumeRepository = new Mock<IResumeRepository>();
    
    public ResumeService CreateStub(IResumeRepository? resumeRepository)
    {
        return new ResumeService(resumeRepository ?? _resumeRepository.Object);
    }
}