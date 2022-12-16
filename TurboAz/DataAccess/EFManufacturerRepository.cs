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
    public class EFManufacturerRepository : IManufacturerRepository
    {
        public void AddData(Manufacturer data)
        {
            using (var context = new MyContext())
            {
                context.Manufacturers.Add(data);
                context.SaveChanges();
                
            }
        }

        public void DeleteData(Manufacturer data)
        {
            using (var context = new MyContext())
            {
                context.Entry(data).State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public ICollection<Manufacturer> GetAll()
        {
            List<Manufacturer> manufacturers = null;
            using (var context = new MyContext())
            {
                manufacturers = context.Manufacturers.ToList();
                return manufacturers;
            }
        }

        public Manufacturer GetData(int id)
        {
            using (var context=new MyContext())
            {
                var data = context.Manufacturers.Include(nameof(Car)).FirstOrDefault(c => c.Id==id);
                return data;
            }
        }

        public void UpdateData(Manufacturer data)
        {
            using (var context = new MyContext())
            {
                context.Entry(data).State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
