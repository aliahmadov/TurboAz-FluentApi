using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurboAz.Domain.Entities
{
    public class Color
    {

        public int Id { get; set; }

        public string ColorName { get; set; }

        public virtual ICollection<Car> Cars { get; set; }
    }
}
