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
    public class CourseManager : ICourseService
    {

        private readonly ICourseDal _coursedal;

        public CourseManager(ICourseDal coursedal)
        {
            _coursedal = coursedal;
        }

        public void Add(Course course)
        {
            _coursedal.Add(course);
        }

        public void Delete(int id)
        {
            _coursedal.Delete(id);
        }

        public List<Course> GetAll()
        {
            return _coursedal.GetAll(); 
        }

        public Course GetById(int id)
        {
            return _coursedal.GetById(id);
        }
    }
}
