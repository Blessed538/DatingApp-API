using DatingApp.API.Models;
using Microsoft.EntityFrameworkCore;

namespace DatingApp.API.Data
{
  public class DataContext : DbContext
  {
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    { }
    public DbSet<WeatherForecast> Weathers { get; set; }
    public DbSet<Weather> Weather { get; internal set; }
  }
}