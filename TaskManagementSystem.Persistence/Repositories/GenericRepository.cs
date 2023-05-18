using Microsoft.EntityFrameworkCore;
using TaskManagementSystem.Application;
using TaskManagementSystem.Application.Contracts.Persistence;

namespace TaskManagementSystem.Persistence.Repositories;

public class GenericRepository<T>: IGenericRepository<T> where T: BaseModel
{
    private readonly AppDbContext _context;
    
    public GenericRepository(AppDbContext context)
    {
        _context = context;
    }
    
    public async Task<T?> Get(int id)
    {
        return await _context.Set<T>().FindAsync(id);   
    }

    public async Task<List<T>> GetAll()
    {
        return await _context.Set<T>().ToListAsync();
    }

    public async Task<T> Add(T entity)
    {
        await _context.AddAsync(entity);
        return entity;
    }

    public async Task<bool> Exists(int id)
    {
        return (await _context.Set<T>().FindAsync(id)) != null;
    }

    public async Task Update(T entity)
    {
        _context.Entry(entity).State = EntityState.Modified;
    }

    public async Task Delete(T entity)
    {
        _context.Set<T>().Remove(entity);
    }
}