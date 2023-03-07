using Application.Interfaces;
using Application.Services;
using Moq;

namespace HomePageServiceTests.Mock.Stubs;

public class HomePageServiceStub
{
    private readonly Mock<IResumeRepository> _resumeRepository = new Mock<IResumeRepository>();

    public HomePageService CreateStub(IResumeRepository? resumeRepository)
    {
        return new HomePageService(resumeRepository ?? _resumeRepository.Object );
    }
}