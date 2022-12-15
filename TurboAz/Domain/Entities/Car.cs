using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurboAz.Domain.Entities
{
    public class Car
    {

        public int Id { get; set; }

        public int ProductionYear { get; set; }

        public double Price { get; set; }

        public bool IsOld { get; set; }

        public int UsageDistance { get; set; }
        public int ColorId { get; set; }
        public Color Color { get; set; }

        public int ModelId { get; set; }
        public Model Model { get; set; }

        public int EnergyTypeId { get; set; }
        public EnergyType EnergyType { get; set; }

        public int BanTypeId { get; set; }
        public BanType BanType { get; set; }

        public int ManufacturerId { get; set; }

        public Manufacturer Manufacturer { get; set; }
    }
}
