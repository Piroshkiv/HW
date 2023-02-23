namespace PW_4_3_ModuleTask.Configurations;

public class GenreConfiguration : IEntityTypeConfiguration<Genre>
{
    public void Configure(EntityTypeBuilder<Genre> builder)
    {
        builder.ToTable("Genre");
        builder.Property(e => e.Title).HasMaxLength(50);

        builder.HasData(
            new() { Id = 1, Title = "Rock" },
            new() { Id = 2, Title = "Metal" },
            new() { Id = 3, Title = "Rap" },
            new() { Id = 4, Title = "Chanson"},
            new() { Id = 5, Title = "Classical"}
            );
    }
}
