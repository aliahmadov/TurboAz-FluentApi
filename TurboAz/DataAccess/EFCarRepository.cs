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
    public class EFCarRepository : ICarRepository
    {
        public void AddData(Car data)
        {
            using (var context = new MyContext())
            {
                context.Cars.Add(data);
                context.SaveChanges();
            }
        }

        public void DeleteData(Car data)
        {
            using (var context = new MyContext())
            {
                context.Entry(data).State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public ICollection<Car> GetAll()
        {
            List<Car> cars = null;
            using (var context = new MyContext())
            {
                cars = context.Cars
                    .Include(nameof(Manufacturer))
                    .Include(nameof(BanType))
                    .Include(nameof(EnergyType))
                  .Include("Color")
                    .ToList();
            }
            return cars;
        }

        public Car GetData(int id)
        {
            using (var context = new MyContext())
            {
                var data = context.Cars.FirstOrDefault(c => c.Id == id);
                return data;
            }
        }

        public void UpdateData(Car data)
        {
            using (var context = new MyContext())
            {
                context.Entry(data).State = EntityState.Modified;
            }
        }
    }
}
