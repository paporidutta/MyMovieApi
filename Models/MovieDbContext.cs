using Microsoft.EntityFrameworkCore;

namespace MyMovieApi.Models
{
    public class MovieDbContext : DbContext
    {
        public MovieDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Movie> movies { get; set; }
    }
}