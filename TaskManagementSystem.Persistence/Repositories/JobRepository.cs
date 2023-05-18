using TaskManagementSystem.Application;
using TaskManagementSystem.Application.Contracts.Persistence;

namespace TaskManagementSystem.Persistence.Repositories;

public class JobRepository: GenericRepository<Job>, IJobRepository
{
    public JobRepository(AppDbContext context): base(context)
    {
        
    }
}