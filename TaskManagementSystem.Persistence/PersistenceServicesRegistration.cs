using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using TaskManagementSystem.Application.Contracts.Persistence;
using TaskManagementSystem.Persistence.Repositories;

namespace TaskManagementSystem.Persistence;

public static class PersistenceServicesRegistration
{
    public static IServiceCollection ConfigurePersistenceServices(this IServiceCollection services,
        IConfiguration configuration)
    {
        
        services.AddScoped<IUnitOfWork, UnitOfWork>();
        services.AddScoped<IJobRepository, JobRepository>();
        services.AddScoped<IChecklistRepository, ChecklistRepository>();
        
        services.AddDbContext<AppDbContext>(opt => 
            opt.UseNpgsql(configuration.GetConnectionString("DefaultConnection")));

        return services;
    }
}