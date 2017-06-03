using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.X
{
    class Program
    {
        static void Main(string[] args)
        { 
            var n = int.Parse(Console.ReadLine());
            var t = 0;
            var m = n - 2;
            var k = 1;
            var e = (n - 3)/2;
            for (int i = 0; i <= n/2-1; i++)
            {
                Console.WriteLine("{1}x{0}x{1}", new string(' ',m), new string(' ',t));
                t++;
                m-=2;

            }
            Console.WriteLine("{0}x{0}", new string(' ',n/2));

            for (int i = 0; i <= n/2-1; i++)
            {
                Console.WriteLine("{0}x{1}x{0}", new string(' ',e), new string(' ',k));
                k += 2;
                e--;
            }

            }
    }
}
