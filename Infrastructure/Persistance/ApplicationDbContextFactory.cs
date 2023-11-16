using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace Persistance.Repositories
{
    public class ApplicationDbContextFactory : IDesignTimeDbContextFactory<ApplicationDbContext>
    {
        public ApplicationDbContext CreateDbContext(string[] args)
        {
            var connectionString = GetConnectionString();
            var builder = new DbContextOptionsBuilder<ApplicationDbContext>();
       
            builder.UseSqlServer(connectionString);


            return new ApplicationDbContext(builder.Options);
        }
        private static string? GetConnectionString()
        {
            var currentDirectory = Directory.GetCurrentDirectory();

            var appsettingsPath = Path.Combine(currentDirectory, "..", "..", "Presentation",  "appsettings.json");

            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(currentDirectory)
                .AddJsonFile(appsettingsPath, optional: false)
                .Build();
            var connectionString = configuration.GetConnectionString("DefaultConnection");
            return connectionString;
        }
    }
}