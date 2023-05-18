namespace TaskManagementSystem.Application.Contracts.Persistence;

public interface IUnitOfWork
{
    public IJobRepository _jobRepository { get; }
    public IChecklistRepository _checklistRepository { get; }
    
    public Task<int> Save();
}