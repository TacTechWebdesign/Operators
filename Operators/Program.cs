using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
     class Program
    {
        static void Main(string[] args)
        {
            Employee emp1 = new Employee(20040, "Rica", "Reyes");
            Employee emp2 = new Employee(20040, "Selena", "Gomez");
            Employee emp3 = new Employee(20041, "Haile", "Bebir");

            Console.WriteLine("Are {0} {1} and {2} {3} have the same ID? \n" + (emp1 == emp2), emp1.FirstName, emp1.LastName, emp2.FirstName, emp2.LastName);
            Console.ReadLine();

            Console.WriteLine("Are {0} {1} and {2} {3} have the same ID? \n" + (emp1 == emp3), emp1.FirstName, emp1.LastName, emp3.FirstName, emp3.LastName);
            Console.ReadLine();

            Console.WriteLine("Are {0} {1} and {2} {3} different ID? \n" + (emp2 != emp3), emp2.FirstName, emp2.LastName, emp3.FirstName, emp3.LastName);
            Console.ReadLine();
        }
    }
}
