using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace PreTestSchool.Data;

public class ApplicationDbContext : IdentityDbContext<ApplicationTeachers>
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public DbSet<ApplicationTopics> Topics { get; set; }
    public DbSet<ApplicationLessons> Lessons { get; set; }
}