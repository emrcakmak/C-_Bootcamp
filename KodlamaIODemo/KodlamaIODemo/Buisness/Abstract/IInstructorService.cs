using KodlamaIODemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIODemo.Buisness.Abstract
{
    public interface IInstructorService
    {

        List<Instructor> GetAll();
        void Add(Instructor ınstructor);
        void Delete(int id);
        Instructor GetById(int id);
    }
}
