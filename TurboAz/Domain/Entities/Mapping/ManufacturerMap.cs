using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurboAz.Domain.Entities.Mapping
{
    public class ManufacturerMap:EntityTypeConfiguration<Manufacturer>
    {

        public ManufacturerMap()
        {
            this.ToTable("Manufacturers");

            this.HasKey(c => c.Id);

            this.Property(c => c.Id).HasColumnName("Id");

            this.Property(c => c.Name)
                .HasMaxLength(40)
                .IsRequired();

            this.Property(c => c.Name).HasColumnName("ManuacturerName");

            this.HasMany(c => c.Cars)
                .WithRequired()
                .HasForeignKey(c => c.ManufacturerId)
                .WillCascadeOnDelete(true);

        
        
        }


    }
}
