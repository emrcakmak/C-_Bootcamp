using KodlamaIODemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIODemo.Buisness.Abstract
{
    public interface ICatagoryService
    {
        List<Catagory> GetAll();
        void Add(Catagory category);
        void Delete(int id);
        Catagory GetById(int id);
    }
}
