using Kodlama_Io.DataAccess.Abstract;
using Kodlama_Io.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodlama_Io.DataAccess.Concrete
{
    public class InstructorDal : IInstructorDal
    {
        private List<Instructor> _instructors;
        
        public InstructorDal()
        {
            _instructors = new List<Instructor>
            {
                new Instructor {FirstName="Metehan",LastName="Bayrakdar"},
                new Instructor {FirstName="Emirhan",LastName="Bayrakdar"}
            };

        }




        public void Add(Instructor item)
        {
            _instructors.Add(item);
        }

        public void Delete(int id)
        {
            Instructor filteredInstructor = Get(id);
            if(filteredInstructor != null)
            {
                _instructors.Remove(filteredInstructor);
            }
            
        }

        public Instructor Get(int id)
        {
            return _instructors.Where(i=>i.Id == id).FirstOrDefault();
        }

        public List<Instructor> GetAll()
        {
            return _instructors;
        }

        public void Update(Instructor item)
        {
            Instructor filteredInstructor = Get(item.Id);
            filteredInstructor.FirstName = item.FirstName;
            filteredInstructor.LastName = item.LastName;
        }
    }
}
