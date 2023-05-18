using TaskManagementSystem.Application.Contracts.Persistence;

namespace TaskManagementSystem.Persistence.Repositories;

public class UnitOfWork: IUnitOfWork
{
    public IJobRepository _jobRepository { get; set; }
    public IChecklistRepository _checklistRepository { get; set; }
    
    private readonly AppDbContext _context;
    
    public UnitOfWork(AppDbContext context)
    {
        _context = context;
    }
    
    public IJobRepository JobRepository { 
        get 
        {
            if (_jobRepository == null)
                _jobRepository = new JobRepository(_context);
            return _jobRepository;
        } 
    }
    
    public IChecklistRepository ChecklistRepository { 
        get 
        {
            if (_checklistRepository == null)
                _checklistRepository = new ChecklistRepository(_context);
            return _checklistRepository;
        } 
    }

    public async Task<int> Save()
    {
        return await _context.SaveChangesAsync();
    }
}