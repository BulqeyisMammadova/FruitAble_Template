using Microsoft.EntityFrameworkCore;

namespace Fruitable.Data;

public class AppDbContext:DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {

    }
}
