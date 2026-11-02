using GameVault.Models;
using Microsoft.EntityFrameworkCore;

namespace GameVault.Data;

public class GameVaultContext : DbContext
{
    // The options (connection string + provider) are injected via DI; see Program.cs
    public GameVaultContext(DbContextOptions<GameVaultContext> options)
        : base(options)
    {
    }

    public DbSet<Game> Games => Set<Game>();
    public DbSet<Genre> Genres => Set<Genre>();
    public DbSet<Developer> Developers => Set<Developer>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Game>()
            .HasOne(g => g.Genre)
            .WithMany(x => x.Games)
            .HasForeignKey(g => g.GenreId)
            .OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Entity<Game>()
            .HasOne(g => g.Developer)
            .WithMany(x => x.Games)
            .HasForeignKey(g => g.DeveloperId)
            .OnDelete(DeleteBehavior.Restrict);

        // Test data - inserted by the InitialCreate migration
        modelBuilder.Entity<Genre>().HasData(SeedData.Genres);
        modelBuilder.Entity<Developer>().HasData(SeedData.Developers);
        modelBuilder.Entity<Game>().HasData(SeedData.Games);
    }
}
