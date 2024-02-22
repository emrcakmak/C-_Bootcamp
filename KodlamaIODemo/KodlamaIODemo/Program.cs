using KodlamaIODemo.Buisness.Concreate;
using KodlamaIODemo.DataAccsess.Concreate;
using KodlamaIODemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIODemo
{
    public class Program
    {
        static void Main(string[] args)
        {
            CatagoryManager categorym=new CatagoryManager(new CatagoryDal());
            categorym.Add(new Catagory(3, "Back-End"));
            Console.WriteLine("new category added");

            categorym.GetAll();

            //***************************************************************************************

            Console.WriteLine("***********************************************************************************");
            CourseManager coursem = new CourseManager(new CourseDal());
            coursem.Add(new Course(1,"Python",5,1));
            Console.WriteLine("new course added");

            coursem.GetAll();

            //***************************************************************************************

            Console.WriteLine("***********************************************************************************");
            InstructorManager ınstructor = new InstructorManager(new InstructorDal());
            ınstructor.Add(new Instructor(3,"Hasan","Öztürk"));
            Console.WriteLine("new ınstructor added");

            ınstructor.GetAll();


            Console.ReadLine();
        }
    }
}
