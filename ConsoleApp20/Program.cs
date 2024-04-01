using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employe employe1 = new PartTimeEmploye(1, "Ali", 500, 60);
            Employe employe2 = new FullTimeEmploye(2, "Vali", 1500, 25);
            Employe employe3 = new PartTimeEmploye(3, "Aygun", 500, 85);
            Employe employe4 = new FullTimeEmploye(4, "Ayse", 5000, 30);

            Employe[] emp = new Employe[] { employe1, employe2, employe3, employe4 };
            foreach(var equals in emp)
            {
                equals.DisplayInfo();
            }

        }
    }
}
