using Kodlama_Io.DataAccess.Abstract;
using Kodlama_Io.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodlama_Io.DataAccess.Concrete
{
    public class CourseDal:ICourseDal
    {
        private List<Course> _courses;


        public CourseDal()
        {
            Course course = new Course { Id = 1, CategoryId = 1, CourseName = "Backend Course", Description = "C#/.net Advanced Course", Language = "C#" }; new Course { Id = 2, CategoryId = 2, CourseName = "Frontend Course", Description = "JavaScript Advanced Course", Language = "JavaScript" };
        }

        public void Add(Course item)
        {
            _courses.Add(item);
        }
        public void Delete(int id)
        {
            Course filteredCourse = Get(id);
            if (filteredCourse != null)
            {
                _courses.Remove(filteredCourse);
            }
        }

        public Course Get(int id)
        {
            return _courses.Where(c => c.Id == id).FirstOrDefault();
        }

        public List<Course> GetAll()
        {
            return _courses;
        }


        public List<Course> GetCourseCategory(int id)
        {
            return _courses.Where(c => c.CategoryId == id).ToList();
        }

        public List<Course> GetCourseInstructor(int id)
        {
            return _courses.Where(c => c.InstructorId == id).ToList();
        }


        public void Update(Course item)
        {
            Course filteredCourse = Get(item.Id);
            filteredCourse.CategoryId = item.CategoryId;
            filteredCourse.InstructorId = item.InstructorId;
            filteredCourse.CourseName = item.CourseName;
            filteredCourse.Description = item.Description;
            filteredCourse.Language = item.Language;
        }

    }
}
