using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp20
{
    internal class FullTimeEmploye : Employe
    {
        public int VacationDays { get; set; }


        public FullTimeEmploye(int id, string name, double salary, int vDays) : base(id, name, salary)
        {
            VacationDays = vDays;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Vacationdays:{VacationDays}");
        }

    }
}
