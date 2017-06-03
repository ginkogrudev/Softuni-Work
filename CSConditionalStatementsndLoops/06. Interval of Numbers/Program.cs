using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Interval_of_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstNumber = int.Parse(Console.ReadLine());
            var secoundNumber = int.Parse(Console.ReadLine());

            var end = Math.Max(firstNumber, secoundNumber);
            var start = Math.Min(firstNumber, secoundNumber);

            for (int i = start; i <= end; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
