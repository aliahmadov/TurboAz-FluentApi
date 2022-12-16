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
    public class EFModelRepository : IModelRepository
    {
        public void AddData(Model data)
        {
            using (var context = new MyContext())
            {
                context.Models.Add(data);
                context.SaveChanges();
            }
        }

        public void DeleteData(Model data)
        {
            using (var context = new MyContext())
            {
                context.Entry(data).State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public ICollection<Model> GetAll()
        {
            List<Model> models = null;

            using (var context = new MyContext())
            {
                models = context.Models.ToList();
                return models;
            }
        }

        public Model GetData(int id)
        {
            using (var context = new MyContext())
            {
                var data = context.Models.FirstOrDefault(c => c.Id == id);
                return data;
            }
        }

        public void UpdateData(Model data)
        {
            using (var context = new MyContext())
            {
                context.Entry(data).State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
