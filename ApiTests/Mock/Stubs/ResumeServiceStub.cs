using Domain.Interfaces;
using Domain.Repositories;
using Domain.Services;
using Moq;
using Persistence;
using Persistence.Models;

namespace HomePageServiceTests.Mock.Stubs;

public class ResumeServiceStub
{
   
    
    public ResumeService CreateStub(Context context)
    {
        return new ResumeService(context);
    }
}