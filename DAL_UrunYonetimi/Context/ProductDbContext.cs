using DAL_UrunYonetimi.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_UrunYonetimi.Context
{
    public class ProductDbContext : DbContext
    {

        public DbSet<Product> Products { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-QJIAQ3L;DataBase=Ank18ProductDb;Trusted_Connection=true;trustservercertificate=true");
        }
    }
}
