using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace typaG
{
    class Program
    {
        static void Main(string[] args)
        {
            var people = int.Parse(Console.ReadLine());
            var package = Console.ReadLine();


            var packagePrice = 0.00;
            var packegeDis = 0.00;
            var hallPrice = 0.00;
            var hallName = "koasx";
            if (package == "Normal")
            {
                packagePrice = 500;
                packegeDis = 0.95;
            }
            else if (package == "Gold")
            {
                packagePrice = 750;
                packegeDis = 0.90;
            }
            else if (package == "Platinum")
            {
                packagePrice = 1000;
                packegeDis = 0.85;
            }

            if (people <= 50)
            {
                hallPrice = 2500;
                hallName = "Small Hall";
            }
            else if (people <= 100)
            {
                hallPrice = 5000;
                hallName = "Terrace";
            }
            else if (people <= 120)
            {
                hallPrice = 7500;
                hallName = "Great Hall";
            }
            if (people >= 120)
            {
                Console.WriteLine("We do not have an appropriate hall.");

            }
            else
            {

                Console.WriteLine($"We can offer you the {hallName}");
                Console.WriteLine($"The price per person is {((packagePrice + hallPrice) * packegeDis / people):f2}$");

            }
        }
    }
}
