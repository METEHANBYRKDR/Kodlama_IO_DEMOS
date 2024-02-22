﻿using Kodlama_Io.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodlama_Io.Business.Abstract
{
    public interface ICourseBusiness : IBusiness<Course>
    {
        List<Course> GetCourseCategory(int id);
        List<Course> GetCourseInstructor(int id);

    }
}
