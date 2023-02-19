using Microsoft.EntityFrameworkCore;
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

            builder.HasData(
                    new() { Id = 1, FirstName = "Artur", LastName = "Piroshkiv", Phone = "+380786847267", Email = "ArturPiroshkiv@gmail.com" },
                    new() { Id = 2, FirstName = "Ihor", LastName = "Jakirov", Phone = "+380987878783", Email = "IhorJakirov@gmail.com" },
                    new() { Id = 3, FirstName = "Daniil", LastName = "Morphovich", Phone = "+380926402640", Email = "DaniilMorphovich@gmail.com" },
                    new() { Id = 4, FirstName = "Maxim", LastName = "Nalivaiko", Phone = "+380027397293", Email = "MaximNalivaiko@gmail.com" },
                    new() { Id = 5, FirstName = "Denis", LastName = "Prolivaiko", Phone = "+380027397293", Email = "DenisProlivaiko@gmail.com" }
                    );
        }
    }
}
