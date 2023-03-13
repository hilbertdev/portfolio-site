

using Persistence.Models;

namespace HomePageServiceTests.Mock.Builders;

public  class ProfileResumeBuilder
{
    public Resume Build()
    {
        return new Resume
        {
            ProfileId = Guid.NewGuid(),
        };
    }
}