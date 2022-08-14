using Microsoft.EntityFrameworkCore;
using PLATFORMSERVICE.Models;

namespace PLATFORMSERVICE.Data
{
    public static class PrepDb
    {
        public static void PrepPopulation(WebApplication app, bool isProd)
        {
            using (var serviceScope = app.Services.CreateScope())
            {
                SeedData(serviceScope.ServiceProvider.GetService<AppDbContext>(),isProd);
            }
        }

        private static void SeedData(AppDbContext context, bool isProd)
        {
            if(isProd)
            {
                Console.WriteLine("--> Attempting to apply migrations...");
                try
                {
                    context.Database.Migrate();
                }
                catch(Exception ex)
                {
                    Console.WriteLine($"--> Cound not run migration: {ex.Message}");
                }
            }

            if (!context.Platforms.Any())
            {
                Console.WriteLine("--> Seeding Data...");

                context.Platforms.AddRange(
                    new Platform() { Name = "Dot Net", Publsher = "Microsoft", Cost = "Free" },
                    new Platform() { Name = "SQL Server Express", Publsher = "Microsoft", Cost = "Free" },
                    new Platform() { Name = "Kubernetes", Publsher = "Cloud Native Computing Foundation", Cost = "Free" }
                    );
                context.SaveChanges();
            }
            else
            {
                Console.WriteLine("--> We already have data");
            }
      
        }
    }
}
