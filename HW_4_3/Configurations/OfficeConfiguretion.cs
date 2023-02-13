
namespace HW_4_3.Configurations
{
    public class OfficeConfiguretion : IEntityTypeConfiguration<Office>
    {
        public void Configure(EntityTypeBuilder<Office> builder)
        {
            builder.ToTable("Office").HasIndex(o => o.Id);
            builder.Property(o => o.Id).HasColumnName("OfficeId").ValueGeneratedOnAdd();
            builder.Property(o => o.Title).IsRequired().HasMaxLength(100);
            builder.Property(o => o.Location).IsRequired().HasMaxLength(100);
        }
    }
}
