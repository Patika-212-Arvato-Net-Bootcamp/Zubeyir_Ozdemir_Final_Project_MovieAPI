using Microsoft.EntityFrameworkCore;

namespace MovieProjectAPI.EfCore
{
    public class EF_DataContext : DbContext
    {
        public EF_DataContext(DbContextOptions<EF_DataContext> options) : base(options) { }
        public DbSet<Movie> Movies { get; set; }

    }
}