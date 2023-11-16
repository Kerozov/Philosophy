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
            var currentDirectory = Directory.GetCurrentDirectory();
            var presentationDirectory = Path.Combine(currentDirectory, "..","..", "Presentation");
            
            var appsettingsPath = Path.Combine(presentationDirectory, "Presentation", "appsettings.json");
            
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(presentationDirectory)
                .AddJsonFile(appsettingsPath, optional: false)
                .Build();
            var builder = new DbContextOptionsBuilder<ApplicationDbContext>();
            var connectionString = configuration.GetConnectionString("DefaultConnection");
            builder.UseSqlServer(connectionString);


            return new ApplicationDbContext(builder.Options);
        }
    }
}