using Application.Interfaces;
using HomePageServiceTests.Mock.Builders;
using HomePageServiceTests.Mock.Stubs;
using Moq;

namespace HomePageServiceTests.Services;

public class HomepageServiceTests
{
    
    [Fact]
    public async Task LoadProfileResume_Success()
    {
        //arrange 
        var profileId = Guid.NewGuid();
        var profileResume = new ProfileResumeBuilder().WithProfileId(profileId).Build();
        
        var resumeRepositoryMock = new Mock<IResumeRepository>();

        resumeRepositoryMock.Setup(x => x.GetResumeByProfileId(profileId)).ReturnsAsync(profileResume);
        var homepageServiceStub = new HomePageServiceStub().CreateStub(resumeRepositoryMock.Object);
        //act
        var result = await homepageServiceStub.LoadProfileResume(profileId);
        
        //assert
        Assert.Equal(profileId, result.ProfileId);
        resumeRepositoryMock.Verify(x => x.GetResumeByProfileId(profileId), Times.Once);
    }
}


