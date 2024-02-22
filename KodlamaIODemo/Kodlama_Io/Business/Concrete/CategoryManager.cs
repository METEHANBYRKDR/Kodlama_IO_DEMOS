using Kodlama_Io.Business.Abstract;
using Kodlama_Io.DataAccess.Abstract;
using Kodlama_Io.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodlama_Io.Business.Concrete
{
    public class CategoryManager: ICategoryBusiness
    {
        private ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }
        public void Add(Category item)
        {
            _categoryDal.Add(item);
        }
        public void Delete(int id) 
        { 
            _categoryDal.Delete(id);
        }
        public Category Get(int id)
        {
            return _categoryDal.Get(id);
        }
        public List<Category> GetAll()
        {
            return _categoryDal.GetAll();
        }   
        public void Update(Category item)
        {
            _categoryDal.Update(item);
        }

    }
}
