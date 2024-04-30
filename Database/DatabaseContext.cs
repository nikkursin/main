using Countries.Models;
using Microsoft.EntityFrameworkCore;

namespace temp.Database;

public class ApplicationContext : DbContext
{
  public DbSet<CityModel>? Cities { get; set; }
  public DbSet<CountryModel>? Countries { get; set; }

  protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
  {
    optionsBuilder.UseSqlite("Data Source=.\\Database\\CountriesDB.db");
  }
  protected override void OnModelCreating(ModelBuilder modelBuilder)
  {
    // modelBuilder.Entity<User>()
    //   .HasOne(p => p.Company)
    //   .WithMany(t => t.Users)
    //   .OnDelete(DeleteBehavior.Cascade);
  }
}
