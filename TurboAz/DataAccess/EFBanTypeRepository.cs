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
    public class EFBanTypeRepository : IBanTypeRepository
    {
        public void AddData(BanType data)
        {
            using (var context=new MyContext())
            {
                context.BanTypes.Add(data);
                context.SaveChanges();
            }
        }

        public void DeleteData(BanType data)
        {
            using (var context = new MyContext() )
            {
                context.Entry(data).State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public ICollection<BanType> GetAll()
        {
            List<BanType> banTypes = null;
            using (var context = new MyContext())
            {
                banTypes = context.BanTypes.ToList();
            }
            return banTypes;
        }

        public BanType GetData(int id)
        {
            using (var context = new MyContext())
            {
                var data = context.BanTypes.Include(nameof(BanType.Cars)).FirstOrDefault(c => c.Id==id);
                return data;
            }
        }

        public void UpdateData(BanType data)
        {
            using (var context = new MyContext())
            {
                context.Entry(data).State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
