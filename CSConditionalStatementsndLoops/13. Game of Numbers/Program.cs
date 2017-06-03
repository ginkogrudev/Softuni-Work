using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
namespace _13.Game_of_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var m = int.Parse(Console.ReadLine());
            var magicNumber = int.Parse(Console.ReadLine());

            int combinationCnt = 0;

            for (int i = n; i < m; i++)
            {
                for (int g = n; g < m; g++)
                {
                    if ((i+g) == magicNumber)
                    {
                        Console.WriteLine($"Number found! {g} + {i} = {magicNumber}");
                        return;
                    }
                    combinationCnt++;
                }
            }
            Console.WriteLine();

        }
    }
}
*/

namespace _19._03
{
    class Program
    {
        static void Main(string[] args)
        {
            int end = int.Parse(Console.ReadLine());
            int start = int.Parse(Console.ReadLine());
            int magic = int.Parse(Console.ReadLine());

            var comboCnt = 0;

            for (int i = start; i >= end; i--)
            {
                for (int j = start; j >= end; j--)
                {
                    comboCnt++;
                    if (i + j == magic)
                    {
                        Console.WriteLine($"Number found! {i} + {j} = {magic}");
                        return;
                    }
                }
            }
            Console.WriteLine("{0} combinations - neither equals {1}", comboCnt, magic);
        }
    }
}
