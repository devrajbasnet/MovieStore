
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace MovieStore.Data
{
    public class DatabaseContext : IdentityDbContext <ApplicationUser>
    {
       public DatabaseContext(DbContextOptions<DatabaseContext> options) :base(options)
        {

        }
        public DbSet<Genre> Genre { get; set; }
        public DbSet<MovieGenre> MovieGenre { get; set; }
        public DbSet<Movie> Movies { get; set; }

    }
}
