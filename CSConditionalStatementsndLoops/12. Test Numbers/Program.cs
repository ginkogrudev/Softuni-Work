using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Test_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var m = int.Parse(Console.ReadLine());
            var boundryNumber = int.Parse(Console.ReadLine());

            int sum;
            int total = 0;
            int combinationsCnt = 0;

            for (int i = n; i >= 1; i--)
            {
                for (int g = 1; g <= m; g++)
                {
                    if (total >= boundryNumber)
                    {
                        break;
                    }
                    sum = (i * g)*3;
                    total += sum;
                    combinationsCnt++;
                }
            }
            if (total >= boundryNumber)
            {
                Console.WriteLine($"{combinationsCnt} combinations");
                Console.WriteLine($"Sum: {total} >= {boundryNumber}");
            }
            else
            {
                Console.WriteLine($"{combinationsCnt} combinations");
                Console.WriteLine($"Sum: {total}");
            }

        }
    }
}
