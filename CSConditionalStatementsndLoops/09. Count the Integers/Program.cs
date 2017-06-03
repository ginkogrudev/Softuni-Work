using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Count_the_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            var cnt = 0;
            while (true)
            {
                try
                {
                    var n = int.Parse(Console.ReadLine());
                    cnt++;
                }
                catch (Exception)
                {
                    Console.WriteLine(cnt);
                    return;
                }

            }

        }
    }
}
