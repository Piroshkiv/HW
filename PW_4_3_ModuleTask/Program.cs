using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace PW_4_3_ModuleTask;
internal class Program
{
    private static Config _config;
    static void Main(string[] args)
    {
        var builder = new ConfigurationBuilder();
        builder
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", false);

        var configuration = builder.Build();

        _config = new Config();
        IConfigurationSection section = configuration.GetSection("Project");

        section.Bind(_config);
        WriteSong();
        WriteSongCount();
        SongNestedQuery();
    }

    public static void WriteSong()
    {
        Console.WriteLine("Query task 1: ");
        Console.WriteLine();

        using var db = new SongContext(_config.ConnectionString);
        db.ChangeTracker.AutoDetectChangesEnabled = false;
        var songs = db.Songs
            .Include(b => b.Artists)
            .Include(b => b.Genre)
            .Where(s => s.Genre != null && s.Artists.Any(a => a.DateOfDeath != null))
            .Select(s => new 
                { 
                    Name = s.Title,
                    ArtistNames = s.Artists.Select(a => a.Name).ToList(),
                    GanreName = s.Genre.Title
                }
            ).ToList();
        Console.WriteLine();

        songs.ForEach(s =>
        {
            Console.Write(s.Name + " " + s.GanreName + " ");
            s.ArtistNames.ForEach(n => Console.Write(n + " "));
            Console.WriteLine();
        });

        Console.WriteLine();
        Console.WriteLine("End query task 1");
        Console.WriteLine();
    }

    public static void WriteSongCount()
    {
        Console.WriteLine("Query task 2: ");
        Console.WriteLine();

        using var db = new SongContext(_config.ConnectionString);
        db.ChangeTracker.AutoDetectChangesEnabled = false;
        var SongCount = db.Genres
            .Include(b => b.Songs)
            .Select(g => new 
            {
                Name = g.Title,
                Count = g.Songs.Count
            }
            ).ToList();

        Console.WriteLine();

        SongCount.ForEach(s => Console.WriteLine(s.Name + " " + s.Count));

        Console.WriteLine();
        Console.WriteLine("End query task 2");
        Console.WriteLine();
    }

    public static void SongNestedQuery() 
    {
        Console.WriteLine("Query task 3: ");
        Console.WriteLine();

        using var db = new SongContext(_config.ConnectionString);
        db.ChangeTracker.AutoDetectChangesEnabled = false;

        var songs = db.Songs
            .Where(s => s.ReleasedDate < db.Artists.Select(a => a.DateOfBirth).Max())
            .ToList();

        Console.WriteLine();

        songs.ForEach(s => Console.Write(s.Title + " "));

        Console.WriteLine();
        Console.WriteLine("End query task 3");
        Console.WriteLine();
    }

}
