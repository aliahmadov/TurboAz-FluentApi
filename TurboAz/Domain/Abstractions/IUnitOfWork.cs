using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurboAz.Domain.Abstractions
{
    public interface IUnitOfWork
    {
        IBanTypeRepository BanTypeRepository { get; }

        ICarRepository CarRepository { get; }

        IColorRepository ColorRepository { get; }

        IEnergyTypeRepository EnergyTypeRepository { get; }

        IManufacturerRepository ManufacturerRepository { get; }

        IModelRepository ModelRepository { get; }


    }
}
