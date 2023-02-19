
namespace HW_4_3.Configurations
{
    public class ProjectConfiguretion : IEntityTypeConfiguration<Project>
    {
        public void Configure(EntityTypeBuilder<Project> builder)
        {
            builder.ToTable("Project").HasIndex(p => p.Id);
            builder.Property(p => p.Id).HasColumnName("ProjectId").ValueGeneratedOnAdd();
            builder.Property(p => p.Name).IsRequired().HasMaxLength(50);
            builder.Property(p => p.Budget).IsRequired().HasColumnType("money");
            builder.Property(p => p.StartedDate).IsRequired();
            builder.Property(p => p.ClientId).IsRequired();

            builder.HasOne(p => p.Client).WithMany(c => c.Projects)
                .HasForeignKey(p => p.ClientId).HasPrincipalKey(c => c.Id);

            builder.HasData(
                new() { Id = 1, Name = "Name1", Budget = 8000, StartedDate = DateTime.Now, ClientId = 1 },
                new() { Id = 2, Name = "Name2", Budget = 7000, StartedDate = DateTime.Now, ClientId = 1 },
                new() { Id = 3, Name = "Name3", Budget = 9000, StartedDate = DateTime.Now, ClientId = 1 },
                new() { Id = 4, Name = "Name4", Budget = 3000, StartedDate = DateTime.Now, ClientId = 1 },
                new() { Id = 5, Name = "Name5", Budget = 10000, StartedDate = DateTime.Now, ClientId = 1 }
            );
        }
    }
}
