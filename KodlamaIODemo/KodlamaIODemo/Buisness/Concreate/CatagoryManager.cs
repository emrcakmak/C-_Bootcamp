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
    public class CatagoryManager : ICatagoryService
    {

        private readonly ICatagoryDal _categorydal;

        public CatagoryManager(ICatagoryDal categorydal)
        {
            _categorydal = categorydal;
        }

        public void Add(Catagory category)
        {
            _categorydal.Add(category);
        }

        public void Delete(int id)
        {

            _categorydal.Delete(id);
        }

        public List<Catagory> GetAll()
        {

            return _categorydal.GetAll();
        }

        public Catagory GetById(int id)
        {
            return _categorydal.GetById(id);
        }
    }
}
