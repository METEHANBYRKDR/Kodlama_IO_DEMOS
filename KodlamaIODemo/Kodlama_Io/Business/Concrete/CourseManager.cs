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
    public class CourseManager : ICourseBusiness
    {

        private ICourseDal _courseDal;

        public CourseManager(ICourseDal courseDal)
        {
            _courseDal = courseDal;
        }

        public void Add(Course item)
        {
            _courseDal.Add(item);
        }

        public void Delete(int id)
        {
            _courseDal.Delete(id);
        }

        public Course Get(int id)
        {
           return _courseDal.Get(id);
        }

        public List<Course> GetAll()
        {
            return _courseDal.GetAll();
        }

        public void Update(Course item)
        {
            _courseDal.Update(item);
        }

        public List<Course> GetCourseCategory(int id)
        {
            return _courseDal.GetCourseCategory(id);
        }

        public List<Course> GetCourseInstructor(int id) 
        {
            return _courseDal.GetCourseInstructor(id);
        }






    }
}
