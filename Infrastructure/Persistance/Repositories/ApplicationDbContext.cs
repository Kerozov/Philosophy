using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Persistance.Repositories;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }
    public DbSet<Essay> Essays { get; set; }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Essay>()
            .Property(e => e.Title)
            .HasColumnName("Title")
            .HasMaxLength(255); 
    }
}