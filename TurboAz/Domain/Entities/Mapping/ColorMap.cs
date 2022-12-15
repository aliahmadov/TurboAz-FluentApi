using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurboAz.Domain.Entities.Mapping
{
    public class ColorMap:EntityTypeConfiguration<Color>
    {
        public ColorMap()
        {
            this.ToTable("Colors");

            this.HasKey(c => c.Id);

            this.Property(c => c.ColorName)
                .HasMaxLength(30)
                .IsRequired();

            this.Property(c => c.ColorName).HasColumnName("ColorName");

            this.HasMany(c => c.Cars)
                .WithRequired()
                .HasForeignKey(c => c.ColorId)
                .WillCascadeOnDelete(true); 
        }

    }
}
