using API.Controllers;
using Domain.Interfaces;
using Domain.Repositories;
using Domain.Services;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace API.Infrastructure;

public static class ServiceConfiguration
{
    public static void ConfigureServices(IServiceCollection serviceCollection, IConfiguration configuration)
    {
        serviceCollection.AddScoped<IResumeService, ResumeService>();
        serviceCollection.AddScoped<ISkillService, SkillService>();


        serviceCollection.AddDbContext<Context>(options =>
             options.UseMySQL(configuration.GetConnectionString("DefaultConnection") ?? string.Empty));
    }
}