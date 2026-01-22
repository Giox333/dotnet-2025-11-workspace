/* using Microsoft.EntityFrameworkCore;
using LibreriaEF.Models;

namespace LibreriaEF.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Autore> Autori { get; set; }
        public DbSet<Libro> Libri { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                var configuration = new ConfigurationBuilder()
                    .SetBasePath(Directory.GetCurrentDIrectory())
                    .AddJsonFile("appsettings.json")
                    .Build();

                var connectionString = configuration.GetConnectionString("DefaultConnection");
                optionsBuilder.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Libro>().HashOne(l => l.Autore)
                                        .WithMany(a => a.Libri)
                                        .HasForeignKey(l => l.AutoreId)
                                        .OnDelete(DeleteBehavior.SetNull);
        }
    }
} */

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using LibreriaEF.Models;

namespace LibreriaEF.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Autore> Autori { get; set; }
        public DbSet<Libro> Libri { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                var configuration = new ConfigurationBuilder()
                    .SetBasePath(Directory.GetCurrentDirectory())
                    .AddJsonFile("appsettings.json")
                    .Build();

                var connectionString = configuration.GetConnectionString("DefaultConnection");
                optionsBuilder.UseMySql(connectionString, 
                    ServerVersion.AutoDetect(connectionString));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configura relazione uno-a-molti
            modelBuilder.Entity<Libro>()
                .HasOne(l => l.Autore)
                .WithMany(a => a.Libri)
                .HasForeignKey(l => l.AutoreId)
                .OnDelete(DeleteBehavior.SetNull);
        }
    }
}