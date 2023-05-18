using TaskManagementSystem.Application;
using TaskManagementSystem.Application.Contracts.Persistence;

namespace TaskManagementSystem.Persistence.Repositories;

public class ChecklistRepository: GenericRepository<Checklist>, IChecklistRepository
{
    public ChecklistRepository(AppDbContext context): base(context)
    {
        
    }
}