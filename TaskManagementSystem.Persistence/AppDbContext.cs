using Microsoft.EntityFrameworkCore;
using TaskManagementSystem.Application;

namespace TaskManagementSystem.Persistence;

public class AppDbContext: DbContext
{
    public DbSet<Job> Jobs { get; set; }
    public DbSet<Checklist> Checklists { get; set; }

    public AppDbContext()
    {
        
    }
}