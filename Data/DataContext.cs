using heroApi.Models;
using Microsoft.EntityFrameworkCore;

namespace heroApi.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options): base(options) {}

        public DbSet<SuperHero> SuperHeroes { get; set; }
    }
}
