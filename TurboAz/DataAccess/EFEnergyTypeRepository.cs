using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TurboAz.Domain.Abstractions;
using TurboAz.Domain.Entities;

namespace TurboAz.DataAccess
{
    public class EFEnergyTypeRepository : IEnergyTypeRepository
    {
        public void AddData(EnergyType data)
        {
            using (var context = new MyContext())
            {
                context.EnergyTypes.Add(data);
                context.SaveChanges();
            }
        }

        public void DeleteData(EnergyType data)
        {
            using (var context = new MyContext())
            {
                context.Entry(data).State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public ICollection<EnergyType> GetAll()
        {
            List<EnergyType> energyTypes = null;
            using (var context = new MyContext())
            {
                energyTypes = context.EnergyTypes.ToList();
                return energyTypes;
            }
        }

        public EnergyType GetData(int id)
        {
            using (var context = new MyContext())
            {
                var data = context.EnergyTypes.Include(nameof(Car)).FirstOrDefault(c => c.Id == id);
                return data;
            }
        }

        public void UpdateData(EnergyType data)
        {
            using (var context = new MyContext())
            {
                context.Entry(data).State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
