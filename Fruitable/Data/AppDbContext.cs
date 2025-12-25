using Fruitable.Models;
using Microsoft.EntityFrameworkCore;

namespace Fruitable.Data;

public class AppDbContext:DbContext
{
   public DbSet<Slider> Sliders {  get; set; }
   public DbSet<SliderInfo> SliderInfos { get; set; }
   public DbSet<Setting> Settings { get; set; }
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {

    }
}
