using DAL_UrunYonetimi.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_UrunYonetimi.Entities.Concrete
{
    public class Product : BaseEntity
    {
        public string Name { get; set; }
        public double Price { get; set; }
        
    }
}
