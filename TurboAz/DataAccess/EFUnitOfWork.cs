using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TurboAz.Domain.Abstractions;

namespace TurboAz.DataAccess
{
    public class EFUnitOfWork : IUnitOfWork
    {
        public IBanTypeRepository BanTypeRepository => new EFBanTypeRepository();

        public ICarRepository CarRepository => new EFCarRepository();

        public IColorRepository ColorRepository => new EFColorRepository();

        public IEnergyTypeRepository EnergyTypeRepository => new EFEnergyTypeRepository();

        public IManufacturerRepository ManufacturerRepository => new EFManufacturerRepository();

        public IModelRepository ModelRepository => new EFModelRepository();
    }
}
