using Microsoft.EntityFrameworkCore;
using Pharmacy.Models;
using Microsoft.Extensions.Configuration;

namespace Pharmacy;

public class ApplicationContext : DbContext
{
    public DbSet<Apothecary> Apothecaries { get; set; }
    public DbSet<Country> Countries { get; set; }
    public DbSet<Director> Directors { get; set; }
    public DbSet<Manager> Managers { get; set; }
    public DbSet<Manufacturer> Manufacturers { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<Receiver> Receivers { get; set; }
    public DbSet<Stock> Stocks { get; set; }
    public DbSet<Supply> Supplies { get; set; }

    public ApplicationContext()
    {
        //Database.EnsureCreated();
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.ApplyConfiguration(new CategoryConfiguration());

        base.OnModelCreating(builder);
    }
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var builder = new ConfigurationBuilder();
        builder.SetBasePath(Directory.GetCurrentDirectory());
        builder.AddJsonFile("appsettings.json");
        optionsBuilder.UseSqlServer(builder.Build().GetConnectionString("DefaultConnection"));
    }
}