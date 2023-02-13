
namespace HW_4_3.Configurations
{
    public class TitleConfiguretion : IEntityTypeConfiguration<Title>
    {
        public void Configure(EntityTypeBuilder<Title> builder)
        {
            builder.ToTable("Title").HasIndex(t => t.Id);
            builder.Property(t => t.Id).HasColumnName("TitleId").ValueGeneratedOnAdd();
            builder.Property(p => p.Name).IsRequired().HasMaxLength(50);
        }
    }
}
