using KodlamaIODemo.Buisness.Abstract;
using KodlamaIODemo.DataAccsess.Abstract;
using KodlamaIODemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIODemo.Buisness.Concreate
{
    public class InstructorManager : IInstructorService
    {

        private readonly IInstructorDal _instructordal;

        public InstructorManager(IInstructorDal instructordal)
        {
            _instructordal = instructordal;
        }

        public void Add(Instructor ınstructor)
        {
            _instructordal.Add(ınstructor);
        }

        public void Delete(int id)
        {
            _instructordal.Delete(id);
        }

        public List<Instructor> GetAll()
        {
            return _instructordal.GetAll();
        }

        public Instructor GetById(int id)
        {
            return _instructordal.GetById(id);
        }
    }
}
