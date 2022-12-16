using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurboAz.Domain.Entities.Mapping
{
    public class BanTypeMap:EntityTypeConfiguration<BanType>
    {
        public BanTypeMap()
        {
            this.ToTable("BanTypes");

            this.HasKey(c => c.Id);

            this.Property(c => c.TypeName)
                .HasMaxLength(30)
                .IsRequired();
            this.Property(c => c.TypeName).HasColumnName("TypeName");

            this.HasMany(c => c.Cars)
                .WithRequired()
                .HasForeignKey(c => c.BanTypeId)
                .WillCascadeOnDelete(true);


        }
    }
}
