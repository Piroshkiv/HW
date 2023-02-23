using PW_4_3_ModuleTask.Models;

namespace PW_4_3_ModuleTask.Configurations;

public class ArtistConfiguration : IEntityTypeConfiguration<Artist>
{
    public void Configure(EntityTypeBuilder<Artist> builder)
    {
        builder.ToTable("Artist");
        builder.Property(a => a.Name).HasMaxLength(100);
        builder.Property(a => a.Phone).HasMaxLength(15);
        builder.Property(a => a.Email).HasMaxLength(100);
        builder.Property(a => a.InstagramUrl).HasMaxLength(100);

        builder.HasData(
          new() { Id = 1, Name = "Name1", DateOfBirth = DateTime.Today },
          new() { Id = 2, Name = "Name2", DateOfBirth = DateTime.Today, DateOfDeath = DateTime.Today },
          new() { Id = 3, Name = "Name3", DateOfBirth = DateTime.Today },
          new() { Id = 4, Name = "Name4", DateOfBirth = DateTime.Today, DateOfDeath = DateTime.Today },
          new() { Id = 5, Name = "Name5", DateOfBirth = DateTime.Today }
          );

        builder.HasMany(a => a.Songs)
           .WithMany(s => s.Artists)
           .UsingEntity<Dictionary<string, object>>(
            "ArtistSong",
                j => j.HasOne<Song>().WithMany().HasForeignKey("ArtistId").HasPrincipalKey(a => a.Id),
                j => j.HasOne<Artist>().WithMany().HasForeignKey("SongId").HasPrincipalKey(s => s.Id)
            ).HasData(
            new { ArtistId = 1, SongId = 1 },
            new { ArtistId = 1, SongId = 2 },
            new { ArtistId = 2, SongId = 3 },
            new { ArtistId = 4, SongId = 2 },
            new { ArtistId = 4, SongId = 4 }
             );

      
    }
}

