using Microsoft.EntityFrameworkCore;

namespace sqstr.Models
{
  public class SqstrContext : DbContext
  {
    public SqstrContext(DbContextOptions<SqstrContext> options) : base(options)
    {

    }

    public DbSet<Electricity> Electricities { get; set; }
    public DbSet<Estimate> Estimates { get; set; }
    public DbSet<Flight> Flights { get; set; }
    public DbSet<Fuel> Fuels { get; set; }
    public DbSet<Leg> Legs { get; set; }
    public DbSet<Price> Prices { get; set; }
    public DbSet<SeedAirport> SeedAirports { get; set; }
    public DbSet<SeedCountry> SeedCountries { get; set; }
    public DbSet<SeedFuel> SeedFuels { get; set; }
    public DbSet<SeedSubregion> SeedSubregions { get; set; }
    public DbSet<SeedVehicle> SeedVehicles { get; set; }
  }
}