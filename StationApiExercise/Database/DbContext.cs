using StationApiExercise.Models;
using Microsoft.EntityFrameworkCore;

namespace StationApiExercise.Database;

public class StationDbContext : DbContext
{
    public DbSet<Station> Stations { get; set; }

    public string DbPath { get; }

    public StationDbContext()
    {
        const Environment.SpecialFolder folder = Environment.SpecialFolder.LocalApplicationData;
        var path = Environment.GetFolderPath(folder);
        DbPath = Path.Join(path, "station.db");
        
        // If the DB does not exist, create it
        if (!File.Exists(DbPath))
        {
            var fileStream = new FileStream(DbPath, FileMode.Create);
            fileStream.Close();
        }
    }

    // The following configures EF to create a Sqlite database file in the
    // special "local" folder for your platform.
    protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlite($"Data Source={DbPath}");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Station>().HasData(new Station() { Id = 1, StationUicOrPart = 127 });
        modelBuilder.Entity<Station>().HasData(new Station() { Id = 2, StationUicOrPart = 325 });
        modelBuilder.Entity<Station>().HasData(new Station() { Id = 3, StationUicOrPart = 8600109 });
        modelBuilder.Entity<Station>().HasData(new Station() { Id = 4, StationUicOrPart = 8600810 });

        base.OnModelCreating(modelBuilder);
    }
}