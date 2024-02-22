using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIODemo.Entities
{
    public class Catagory
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Catagory(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
