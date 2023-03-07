

using Persistence.Models;

namespace HomePageServiceTests.Mock.Builders;

public  class ProfileResumeBuilder
{
    private Guid? _profileId = null;

    public Resume Build()
    {
        return new Resume
        {
            ProfileId = _profileId,
        };
    }

    public  ProfileResumeBuilder WithProfileId(Guid? profileId)
    {
        _profileId = profileId;
        return this;
    }
}