
namespace HW_4_3.Configurations
{
    public class EmployeeProjectConfiguration : IEntityTypeConfiguration<EmployeeProject>
    {
        public void Configure(EntityTypeBuilder<EmployeeProject> builder)
        {
            builder.ToTable("EmployeeProject").HasIndex(e => e.Id);
            builder.Property(e => e.Id).HasColumnName("EmployeeProjectId").ValueGeneratedOnAdd();
            builder.Property(e => e.Rate).IsRequired().HasColumnType("money");
            builder.Property(e => e.StartedDate).IsRequired();
            builder.Property(e => e.EmployeeId).IsRequired();
            builder.Property(e => e.ProjectId).IsRequired();

            builder.HasOne(e => e.Employee).WithMany(o => o.EmployeeProjects)
               .HasForeignKey(e => e.EmployeeId).HasPrincipalKey(o => o.Id);

            builder.HasOne(e => e.Project).WithMany(t => t.EmployeeProjects)
                .HasForeignKey(e => e.ProjectId).HasPrincipalKey(t => t.Id);
        }
    }
}
