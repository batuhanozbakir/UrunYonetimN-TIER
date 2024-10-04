using DAL_UrunYonetimi.Context;
using DAL_UrunYonetimi.Entities.Concrete;
using DAL_UrunYonetimi.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_UrunYonetimi.Repositories.Concrete
{
    public class ProductRepository : Repository<Product>
    {
        public ProductRepository(ProductDbContext db) : base (db)
        {
            
        }
    }
}
