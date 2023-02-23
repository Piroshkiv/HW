namespace PW_4_3_ModuleTask;
public class SongContext: DbContext
{
    public SongContext(string connectionString = "Data Source=DESKTOP-DQSJ5BV;Initial Catalog=Songs;Integrated Security=True;") =>
           _connectionString = connectionString;

    private readonly string _connectionString;

    public DbSet<Artist> Artists { get; set; }
    public DbSet<Song> Songs { get; set;}
    public DbSet<Genre> Genres { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) =>
        optionsBuilder.LogTo(Console.WriteLine, Microsoft.Extensions.Logging.LogLevel.Information).UseSqlServer(_connectionString);

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new GenreConfiguration());
        modelBuilder.ApplyConfiguration(new SongConfiguration());
        modelBuilder.ApplyConfiguration(new ArtistConfiguration());
       
        
    }

}
