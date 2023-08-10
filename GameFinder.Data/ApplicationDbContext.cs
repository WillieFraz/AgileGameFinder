using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using GameFinder.Data.Entities;

namespace GameFinder.Data;

public class ApplicationDbContext : IdentityDbContext<User, IdentityRole<int>, int>
{

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options){} 

    public DbSet<Game> Games { get; set; } = null!;


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<User>().ToTable("User");
    }
}