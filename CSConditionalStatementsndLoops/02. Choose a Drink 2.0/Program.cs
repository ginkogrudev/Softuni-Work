using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Choose_a_Drink_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = Console.ReadLine();
            var personCnt = int.Parse(Console.ReadLine());
            var price = 0.00;
            if (person == "Athlete")
            {
                price = 0.70;
            }
            else if (person == "Businessman" || person == "Businesswoman")
            {
                price = 1.00;           
            }
            else if (person == "SoftUni Student")
            {
                price = 1.70;
            }
            else
            {
                price = 1.20;
            }
            var totalPrice = price * personCnt;
            Console.WriteLine($"The {person} has to pay {totalPrice:f2}.");
        }
    }
}
