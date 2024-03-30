using Microsoft.EntityFrameworkCore;
using PreTestSchool.Models;

namespace PreTestSchool.Data;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {

    }

    public DbSet<Teachers> Teachers { get; set; }
    public DbSet<Topics> Topics { get; set; }
    public DbSet<Lessons> Lessons { get; set; }
}