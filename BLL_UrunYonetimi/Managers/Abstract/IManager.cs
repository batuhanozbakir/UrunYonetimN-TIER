using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BLL_UrunYonetimi.Managers.Abstract
{
    internal interface IManager<TModel> where TModel : class
    {
        void Create(TModel model);

        void Update(TModel model);

        void Delete(TModel model); // soft delete 

        void Remove(TModel model); // gerçekten silecek

        List<TModel> GetAll();

        TModel GetById(int id);

        List<TModel> Search(Expression<Func<TModel, bool>> searchCriteria);
    }
}
