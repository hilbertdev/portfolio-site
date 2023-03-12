using Application.Interfaces;
using Application.Repositories;
using Application.Services;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace API.Infrastructure;

public static class ServiceConfiguration
{
    public static void ConfigureServices(IServiceCollection serviceCollection, IConfiguration configuration)
    {
         serviceCollection.AddScoped<IResumeRepository,ResumeRepository>();
         serviceCollection.AddScoped<IHomePageService, HomePageService>();
         serviceCollection.AddDbContext<Context>(options =>
             options.UseMySQL(configuration.GetConnectionString("DefaultConnection") ?? string.Empty));
    }
}