using Kodlama_Io.DataAccess.Abstract;
using Kodlama_Io.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodlama_Io.DataAccess.Concrete
{
    public class CategoryDal : ICategoryDal
    {
        private List<Category> _categories;

        public CategoryDal()
        {
            _categories = new List<Category>
            {
                new Category
                {
                    Id = 1,
                    CategoryName = "Back-End"
                },
                new Category
                { 
                    Id = 2,
                    CategoryName = "Front-End"
                }

            };
        }
        public void Add(Category item) 
        {
            _categories.Add(item);
        }
        public void Delete(int id)
        {
            Category filteredCategory = Get(id);

        }
        public Category Get (int id)
        {
            return _categories.Where(c =>c.Id == id).FirstOrDefault();
        }
        public List<Category> GetAll()
        {
            return _categories;
        }

        public void Update(Category item)
        {
            Category filteredCategory = Get(item.Id);
            filteredCategory.CategoryName = item.CategoryName;
        }

    }

}
