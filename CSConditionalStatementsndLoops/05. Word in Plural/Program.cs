using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Word_in_Plural
{
    class Program
    {
        static void Main(string[] args)
        {
            var noun = Console.ReadLine();
            if (noun.EndsWith("y"))
            {
                string total = noun.Remove(noun.Length - 1);
                Console.WriteLine(total + "ies");
            }
            else if (noun.EndsWith("o") || noun.EndsWith("ch") || noun.EndsWith("s") || noun.EndsWith("sh") || noun.EndsWith("x") || noun.EndsWith("z"))
            {
                Console.WriteLine(noun + "es");
            }
            else
            {
                Console.WriteLine(noun + "s");
            }

        }
    }
}
