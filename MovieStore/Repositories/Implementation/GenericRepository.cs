using Microsoft.EntityFrameworkCore;
using MovieStore.Data;
using System.Collections.Generic;
using System.Threading.Tasks;

public class GenericRepository<T> : IGenericRepository<T> where T : class
{
    private readonly DatabaseContext _context;
    private readonly DbSet<T> _dbSet;

    public GenericRepository(DatabaseContext context)
    {
        _context = context;
        _dbSet = _context.Set<T>();
    }
    public async Task<IEnumerable<T>> GetAllAsync() => await _dbSet.ToListAsync();

    public async Task<T> GetByIdAsync(int id) => await _dbSet.FindAsync(id);

    public async Task AddAsync(T entity) => await _dbSet.AddAsync(entity);

    public void Update(T entity) => _dbSet.Update(entity);

    public void Delete(T entity) => _dbSet.Remove(entity);
}
