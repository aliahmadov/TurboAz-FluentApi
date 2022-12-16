using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using TurboAz.Domain.Abstractions;
using TurboAz.Domain.Entities;

namespace TurboAz.DataAccess
{
    public class EFColorRepository : IColorRepository
    {
        public void AddData(CarColor data)
        {
            using (var context = new MyContext())
            {
                context.CarColors.Add(data);
                context.SaveChanges();
            }
        }

        public void DeleteData(CarColor data)
        {
            using (var context = new MyContext())
            {
                context.Entry(data).State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public ICollection<CarColor> GetAll()
        {
            List<CarColor> carColors = null;
            using (var context = new MyContext())
            {
                carColors = context.CarColors.ToList();
            }
            return carColors;
        }

        public CarColor GetData(int id)
        {
            using (var context = new MyContext())
            {
                var data = context.CarColors.Include(nameof(Car)).FirstOrDefault(c => c.Id == id);
                return data;
            }
        }

        public void UpdateData(CarColor data)
        {
            using (var context = new MyContext())
            {
                context.Entry(data).State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
