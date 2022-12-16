using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TurboAz.Domain.Entities;
using TurboAz.Domain.Entities.Mapping;

namespace TurboAz.DataAccess
{
    public class MyContext : DbContext
    {

        public MyContext() : base("CarDb")
        {

        }

        public DbSet<BanType> BanTypes { get; set; }
        public DbSet<Car> Cars { get; set; }
        public DbSet<CarColor> CarColors { get; set; }
        public DbSet<EnergyType> EnergyTypes { get; set; }
        public DbSet<Manufacturer> Manufacturers { get; set; }
        public DbSet<Model> Models { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new BanTypeMap());
            modelBuilder.Configurations.Add(new CarMap());
            modelBuilder.Configurations.Add(new ColorMap());
            modelBuilder.Configurations.Add(new EnergyTypeMap());
            modelBuilder.Configurations.Add(new ManufacturerMap());
            modelBuilder.Configurations.Add(new ModelMap());

            //modelBuilder.Entity<Model>().HasOptional(p => p.Car).WithOptionalPrincipal();
        }
    }
}
