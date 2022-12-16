using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurboAz.Domain.Entities.Mapping
{
    public class ModelMap:EntityTypeConfiguration<Model>
    {

        public ModelMap()
        {
            this.ToTable("Models");

            this.HasKey(m => m.Id);

            this.Property(m => m.Name)
                .IsRequired()
                .HasMaxLength(30);
            this.Property(m => m.Name).HasColumnName("ModelName");


            HasRequired(c => c.Car).WithRequiredPrincipal();

        }

    }
}
