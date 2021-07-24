using Microsoft.EntityFrameworkCore;

namespace sqstr.Models
{
  public class SqstrContext : DbContext
  {
    public SqstrContext(DbContextOptions<SqstrContext> options) : base(options)
    {

    }
    
    public DbSet<Attributes> Attributes { get; set; }
    public DbSet<Data> Data { get; set; }
    public DbSet<Root> Roots { get; set; }
    public DbSet<Leg> Legs { get; set; }
    public DbSet<Price> Prices { get; set; }

    // public DbSet<Electricity> Electricities { get; set; }
    // public DbSet<Estimate> Estimates { get; set; }
    // public DbSet<Flight> Flights { get; set; }
    // public DbSet<Fuel> Fuels { get; set; }
    // public DbSet<Leg> Legs { get; set; }
    // public DbSet<SeedAirport> SeedAirports { get; set; }
    // public DbSet<SeedCountry> SeedCountries { get; set; }
    // public DbSet<SeedFuel> SeedFuels { get; set; }
    // public DbSet<SeedSubregion> SeedSubregions { get; set; }
    // public DbSet<SeedVehicle> SeedVehicles { get; set; }
  }
}