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
    public class InstructorManager : IInstructorBusiness
    {
        IInstructorDal _instructorDal;

        public InstructorManager(IInstructorDal instructorDal)
        {
            _instructorDal = instructorDal;
        }


        public void Add(Instructor item)
        {
            _instructorDal.Add(item);
        }

        public void Delete(int id)
        {
            _instructorDal.Delete(id);
        }

        public Instructor Get(int id)
        {
            return _instructorDal.Get(id);
        }

        public List<Instructor> GetAll()
        {
            return _instructorDal.GetAll();
        }

        public void Update(Instructor item)
        {
            _instructorDal.Update(item);
        }
    }
}
