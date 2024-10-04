using BLL_UrunYonetimi.Managers.Abstract;
using BLL_UrunYonetimi.Models;
using DAL_UrunYonetimi.Context;
using DAL_UrunYonetimi.Entities.Concrete;
using DAL_UrunYonetimi.Repositories.Abstract;
using DAL_UrunYonetimi.Repositories.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_UrunYonetimi.Managers.Concrete
{
    public class ProductManager : Manager<ProductModel,Product>
    {
        public ProductManager()
        {
            _repository = new ProductRepository(new ProductDbContext());
        }
    }
}
