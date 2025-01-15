using MovieStore.Data;
public class UnitOfWork : IUnitOfWork
{
    private readonly DatabaseContext _context;
    private IGenericRepository<Movie> _movies;
    public UnitOfWork(DatabaseContext context)
    {
        _context = context;
    }

    public IGenericRepository<Movie> Movies => _movies ??= new GenericRepository<Movie>(_context);

    public async Task SaveAsync() => await _context.SaveChangesAsync();
    public void Dispose() => _context.Dispose();
}
