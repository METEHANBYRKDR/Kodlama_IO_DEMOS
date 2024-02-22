using Kodlama_Io.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodlama_Io.DataAccess.Abstract
{
    public interface ICourseDal : IDataAccessLayout<Course>
    {
        List<Course> GetCourseCategory(int id);
        List<Course> GetCourseInstructor(int id);
    }
}
