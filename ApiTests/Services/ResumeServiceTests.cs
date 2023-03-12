using Domain.Interfaces;
using HomePageServiceTests.Mock.Builders;
using HomePageServiceTests.Mock.Stubs;
using Moq;
using Persistence.Models;

namespace HomePageServiceTests.Services;

public class ResumeServiceTests
{
    [Fact]
    public async Task CreateResume_Success()
    {
        //Arrange 
        var resume = new ProfileResumeBuilder().Build();
        var mockResumeRepoMock = new Mock<IResumeRepository>();
        var resumeServiceStub = new ResumeServiceStub().CreateStub(mockResumeRepoMock.Object);
        
        //Act
        await resumeServiceStub.AddNewProfileResume(resume);
        
        //Assert 
        mockResumeRepoMock.Verify(x => x.Create(It.IsAny<Resume>()), Times.Once);

    }
}