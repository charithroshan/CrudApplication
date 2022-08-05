using CrudApplication.Models;
using Microsoft.EntityFrameworkCore;

namespace CrudApplication.Data
{
    public class DataContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "Server = localhost\\sqlexpress; database = CrudApplicationDb; trusted_connection = true";
            optionsBuilder.UseSqlServer(connectionString);
        }
    }
}
