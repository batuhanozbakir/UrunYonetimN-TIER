using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DAL_UrunYonetimi.Repositories.Abstract
{
    public interface IRepository<T> 
    {
        void Create(T entity);

        void Update(T entity);

        void Delete(T entity); // soft delete 

        void Remove(T entity); // gerçekten silecek

        IQueryable<T> GetAll();

        T GetById(int id);

        IQueryable<T> Search(Expression<Func<T,bool>> searchCriteria);
    }
}
