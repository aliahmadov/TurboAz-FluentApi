using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurboAz.Domain.Entities.Mapping
{
    public class CarMap:EntityTypeConfiguration<Car>
    {

        public CarMap()
        {
            this.ToTable("Cars");

            this.HasKey(c => c.Id);

            this.Property(c => c.ImagePath).HasColumnName("ImagePath");

            this.Property(c => c.Id).HasColumnName("Id");

            this.Property(c => c.ProductionYear).HasColumnName("ProductionYear");

            this.Property(c => c.Price).HasColumnName("Price");

            this.Property(c => c.IsOld).HasColumnName("IsOld");

            this.Property(c => c.UsageDistance).HasColumnName("UsageDistance");



                
        }

    }
}
