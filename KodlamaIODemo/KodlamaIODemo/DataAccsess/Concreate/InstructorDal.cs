using KodlamaIODemo.DataAccsess.Abstract;
using KodlamaIODemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIODemo.DataAccsess.Concreate
{
    public class InstructorDal : IInstructorDal
    {

        private List<Instructor> instructors;

        public InstructorDal()
        {
            instructors=new List<Instructor>()
            {
                new Instructor(1,"Emre","Çakmak"),
                new Instructor(2,"Muratcan","Erek")

            };

        }

        public void Add(Instructor ınstructor)
        {
            instructors.Add(ınstructor);
        }

        public void Delete(int id)
        {
            instructors.Remove(instructors.SingleOrDefault(x => x.Id == id));
        }

        public List<Instructor> GetAll()
        {

            foreach (var a in instructors)
            {
                Console.Write(a.Id);
                Console.Write("  ");
                Console.Write(a.Name);
                Console.Write("  ");
                Console.WriteLine(a.Surname);
            }
            return instructors;
        }

        public Instructor GetById(int id)
        {
            return (Instructor)(instructors.Where(a => a.Id == id));
        }
    }
}
