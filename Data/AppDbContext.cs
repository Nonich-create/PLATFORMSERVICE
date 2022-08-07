using Microsoft.EntityFrameworkCore;
using PLATFORMSERVICE.Models;

namespace PLATFORMSERVICE.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> opt) : base(opt)
        { 

        }

        public DbSet<Platform> Platforms { get; set; }
    }
}
