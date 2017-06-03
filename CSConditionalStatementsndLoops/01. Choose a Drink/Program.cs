using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Choose_a_Drink
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = Console.ReadLine();
            if (person == "Athlete")
            {
                Console.WriteLine("Water");
            }
            else if (person == "Businessman" || person == "Businesswoman")
            {
                Console.WriteLine("Coffee");
            }
            else if (person == "SoftUni Student")
            {
                Console.WriteLine("Beer");
            }
            else
            {
                Console.WriteLine("Tea");
            }
        }
    }
}
