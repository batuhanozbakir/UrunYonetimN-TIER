using DAL_UrunYonetimi.Context;
using DAL_UrunYonetimi.Entities.Abstract;
using DAL_UrunYonetimi.Entities.Concrete;
using DAL_UrunYonetimi.Enums;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DAL_UrunYonetimi.Repositories.Abstract
{
    public abstract class Repository<T> : IRepository<T> where T : BaseEntity
    {
        private readonly ProductDbContext _db;
        private DbSet<T> _entities;

        protected Repository(ProductDbContext db)
        {
            _db = db;
            _entities = _db.Set<T>();
        }

        public void Create(T entity)
        {
            entity.DataStatus = DataStatus.Inserted;
            entity.CreatedDate = DateTime.Now;
            _entities.Add(entity);
            _db.SaveChanges();
        }

        public void Delete(T entity)
        {
            entity.DataStatus -= DataStatus.Deleted;
            entity.DeletedDate = DateTime.Now;
            Update(entity);
        }

        public IQueryable<T> GetAll()
        {
                return _entities.Where(e=>e.DataStatus != DataStatus.Deleted);
        }

        public T GetById(int id)
        {
            return _entities.FirstOrDefault(e=>e.Id == id);
        }

        public void Remove(T entity)
        {
            _entities.Remove(entity);
            _db.SaveChanges();
        }

        public IQueryable<T> Search(Expression<Func<T, bool>> searchCriteria)
        {
            var all = _entities.Where(e=>e.DataStatus!= DataStatus.Deleted);
            return all.Where(searchCriteria);
        }

        public void Update(T entity)
        {
            entity.DataStatus = entity.DataStatus!=DataStatus.Deleted ? DataStatus.Updated : DataStatus.Deleted;
            entity.ModifiedDate = DateTime.Now;
            _entities.Update(entity);
            _db.SaveChanges();
        }
    }
}
