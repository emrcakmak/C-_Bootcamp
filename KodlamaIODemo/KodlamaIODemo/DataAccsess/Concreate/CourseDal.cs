using KodlamaIODemo.DataAccsess.Abstract;
using KodlamaIODemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIODemo.DataAccsess.Concreate
{
    public class CourseDal : ICourseDal
    {


        private List<Course> courses;

        public CourseDal()
        {


            courses = new List<Course>()
            {
                new Course(1,"Math",1,1),
                new Course(1,"Diff",2,1),
                new Course(2,"Turkish",3,2),
                new Course(2,"English",4,2)



            };
        }

        public void Add(Course course)
        {
            courses.Add(course);
        }

        public void Delete(int id)
        {
            courses.Remove(courses.SingleOrDefault(x => x.Id == id));
        }

        public List<Course> GetAll()
        {

            foreach (var a in courses)
            {
                Console.Write(a.Id);
                Console.Write("  ");
                Console.Write(a.Name);
                Console.Write("  ");
                Console.Write(a.CatagoryId);
                Console.Write("  ");
                Console.WriteLine(a.InstructorId);
            }
            return courses;
        }

        public Course GetById(int id)
        {
            return (Course)(courses.Where(a => a.Id == id));
        }
    }
}
