namespace PW_4_3_ModuleTask.Configurations;

public class SongConfiguration : IEntityTypeConfiguration<Song>
{
    public void Configure(EntityTypeBuilder<Song> builder)
    {
        builder.ToTable("Song");
        builder.Property(s => s.Title).HasMaxLength(100);
        builder.Property(s => s.GenreId).IsRequired(false);
        builder.HasOne(s => s.Genre).WithMany(g => g.Songs)
             .HasForeignKey(s => s.GenreId).HasPrincipalKey(g => g.Id);

        builder.HasData(
            new Song() { Id = 1, Title = "Title1", Duration = TimeSpan.FromMinutes(3), ReleasedDate = DateTime.Today},
            new Song() { Id = 2, Title = "Title2", Duration = TimeSpan.FromMinutes(2), ReleasedDate = DateTime.Today, GenreId = 5 },
            new Song() { Id = 3, Title = "Title3", Duration = TimeSpan.FromMinutes(3), ReleasedDate = DateTime.Today },
            new Song() { Id = 4, Title = "Title4", Duration = TimeSpan.FromMinutes(4), ReleasedDate = DateTime.Today, GenreId = 2 },
            new Song() { Id = 5, Title = "Title5", Duration = TimeSpan.FromMinutes(3), ReleasedDate = DateTime.Today, GenreId = 1 }
            );

    }
}

