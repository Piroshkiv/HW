using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_4_3.Configurations
{
    public class ClientConfiguretion : IEntityTypeConfiguration<Client>
    {
        public void Configure(EntityTypeBuilder<Client> builder)
        {
            builder.ToTable("Client").HasIndex(c => c.Id);
            builder.Property(c => c.Id).HasColumnName("ClientId");
            builder.Property(c => c.FirstName).IsRequired().HasMaxLength(50);
            builder.Property(c => c.LastName).IsRequired().HasMaxLength(50);
            builder.Property(c => c.Phone).IsRequired().HasMaxLength(15);
            builder.Property(c => c.Email).IsRequired().HasMaxLength(100);
        }
    }
}
