using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Cake_Ingredients
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int ingredientCnt = 0;

            while (input != "Bake!")
            {
                Console.WriteLine($"Adding ingredient {input}.");
                input = Console.ReadLine();
                ingredientCnt++;
            }

            Console.WriteLine($"Preparing cake with {ingredientCnt} ingredients."); ;
                

        }
    }
}
