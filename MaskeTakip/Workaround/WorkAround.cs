using Business.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Workaround
{
     class WorkAround
    {

        static void Main(string[] args)
        {
            Person person1=new Person();
            person1.FirstName = "Emre";
            person1.LasttName = "çAKMAK";
            person1.DateOfBirthYear =2000;
            person1.NationalIdentity = 123;


            PttManager pttmanager=new PttManager(new PersonManager());
            pttmanager.GiveMask(person1);


            Console.ReadLine();





        }

    }
}
