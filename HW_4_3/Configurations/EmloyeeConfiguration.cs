
namespace HW_4_3.Configurations
{
    public class EmloyeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.ToTable("Employee").HasIndex(e => e.Id);
            builder.Property(e => e.Id).HasColumnName("EmployeeId").ValueGeneratedOnAdd();
            builder.Property(e => e.FirstName).IsRequired().HasMaxLength(50);
            builder.Property(e => e.LastName).IsRequired().HasMaxLength(50);
            builder.Property(e => e.HiredDate).IsRequired();
            builder.Property(e => e.DateOfBirth).HasColumnType("date");
            builder.Property(e => e.OfficeId).IsRequired();
            builder.Property(e => e.TitleId).IsRequired();

            builder.HasOne(e => e.Office).WithMany(o => o.Employees)
                .HasForeignKey(e => e.OfficeId).HasPrincipalKey(o => o.Id);

            builder.HasOne(e => e.Title).WithMany(t => t.Employees)
                .HasForeignKey(e => e.TitleId).HasPrincipalKey(t => t.Id);

        }
    }
}
