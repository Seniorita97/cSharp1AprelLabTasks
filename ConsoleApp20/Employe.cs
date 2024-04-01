using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp20
{
    internal class Employe
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }

        public Employe(int id, string name, double salary)
        {
            Name = name;
            Salary = salary;
            Id = id;
        }

        public virtual void DisplayInfo() 
        {
            Console.WriteLine($"Id:{Id} Name:{Name} Salary:{Salary}");
        }
       
    }
}
