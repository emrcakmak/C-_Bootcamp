using KodlamaIODemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIODemo.DataAccsess.Abstract
{
    public interface ICourseDal
    {

        List<Course> GetAll();
        void Add(Course course);
        void Delete(int id);
        Course GetById(int id);
    }
}
