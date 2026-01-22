using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

public class ApplicationDbContext : DbContext
{
    public DbSet<Root> Anime { get; set; }

    //aggiungi altre classi poco per gestire altre tabelle....

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
    /* protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Root>(eb =>
        {
           eb.HasKey(r => r.Id);
           eb.OwnsOne(r => r.meta, mb =>
           {
              mb.Property(mb => mb.page).HasColumnName("Meta_Page");
              mb.Property(mb => mb.size).HasColumnName("Meta_Size");
           }); 

           eb.OwnsMany(r => r.data, db =>
           {
               db.WithOwner().HasForeignKey("RootId");
               db.Property<string>("_id").HasMaxLength(50);
               db.HasKey("_id");
               db.Property(d => d.title).HasMaxLength(300);
               db.Property(d => d.synopsis).HasColumnType("longtext");
               db.ToTable("Datum");
           });
        });

        base.OnModelCreating(modelBuilder);
    } */


}