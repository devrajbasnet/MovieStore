using MovieStore.Data;
using System;
using System.Threading.Tasks;

public interface IUnitOfWork : IDisposable
{
    IGenericRepository<Movie> Movies { get; }
    Task SaveAsync();
    
}
