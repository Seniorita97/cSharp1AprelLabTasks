using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp20
{
    internal class PartTimeEmploye : Employe
    {
        public int HoursWorked { get; set; }

        public PartTimeEmploye(int id, string name, double salary, int hWorked) : base(id, name, salary) 
        {
            HoursWorked = hWorked;  
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"HoursWorked:{HoursWorked}");
        }
    }
}
