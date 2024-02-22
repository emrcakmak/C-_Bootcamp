using KodlamaIODemo.DataAccsess.Abstract;
using KodlamaIODemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIODemo.DataAccsess.Concreate
{
    internal class CatagoryDal : ICatagoryDal
    {


        private List<Catagory> catagories;

        public CatagoryDal()
        {
            catagories = new List<Catagory> { 
            new Catagory(1,"BilgisayarBilimi"),

            new Catagory(2,"Front-End")
            
            };
        }

        public void Add(Catagory category)
        {
            catagories.Add(category);
        }

        public void Delete(int id)
        {
            catagories.Remove(catagories.SingleOrDefault(x => x.Id == id));
        }

        public List<Catagory> GetAll()
        {

            foreach (var a in catagories)
            {
                Console.Write(a.Id);
                Console.Write("  ");
                Console.WriteLine(a.Name);
            }
            return catagories;
        }

        public Catagory GetById(int id)
        {

            return (Catagory)(catagories.Where(a=>a.Id==id));
        }
    }
}
