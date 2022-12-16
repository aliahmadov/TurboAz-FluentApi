using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurboAz.Domain.Entities.Mapping
{
    public class EnergyTypeMap:EntityTypeConfiguration<EnergyType>
    {

        public EnergyTypeMap()
        {
            this.ToTable("EnergyTypes");

            this.HasKey(c => c.Id);

            this.Property(c => c.Id).HasColumnName("Id");

            this.Property(c => c.TypeName)
                .HasMaxLength(40)
                .IsRequired();

            this.Property(c => c.TypeName).HasColumnName("EnergyTypeName");

            this.HasMany(c => c.Cars)
                .WithRequired()
                .HasForeignKey(c => c.EnergyTypeId)
                .WillCascadeOnDelete(true);
        }

    }
}
