using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIODemo.Entities
{
    public class Course
    {

        public int CatagoryId { get; set; }
        public string Name { get; set; }

        public int Id { get; set; }
        public int InstructorId { get; set; }

        public Course(int catagoryId, string name, int id, int instructorId)
        {
            CatagoryId = catagoryId;
            Name = name;
            Id = id;
            InstructorId = instructorId;
        }
    }
}
