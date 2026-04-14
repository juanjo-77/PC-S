using Microsoft.EntityFrameworkCore;
using MySql_Conexion.Models;

namespace MySql_Conexion.Data
{
    public class Database
    {
        public AppDbContext Context { get; }

        public Database()
        {
            var options = new DbContextOptionsBuilder<AppDbContext>()
                .UseMySql(
                    "server=204.168.211.73;database=quasarDB;user=root;password=gWTeX0zTHgGQ6G1",
                    new MySqlServerVersion(new Version(8, 0, 33))
                ).Options;

            Context = new AppDbContext(options);
        }
    }

    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Company> Companies { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Usuario>().ToTable("usuarios");
            modelBuilder.Entity<Company>().ToTable("companies");
        }

    }
}