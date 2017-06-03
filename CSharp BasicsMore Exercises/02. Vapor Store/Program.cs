using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Vapor_Store
{
    class Program
    {
        static void Main(string[] args)
        {
            var money = double.Parse(Console.ReadLine());
            var totalSpend = 0.00;
            var gamePrice = 0.00;
            while (money != 0)
            {
            var game = Console.ReadLine();
                switch (game)
                {
                    case "OutFall 4":
                        gamePrice = 39.99;
                        break;
                    case "CS: OG":
                        gamePrice = 15.99;
                        break;
                    case "Zplinter Zell":
                        gamePrice = 19.99;
                        break;
                    case "Honored 2":
                        gamePrice = 59.99;
                        break;
                    case "RoverWatch":
                        gamePrice = 29.99;
                        break;
                    case "RoverWatch Origins Edition":
                        gamePrice = 39.99;
                        break;
                    case "Game Time":
                        Console.WriteLine($"Total spent: ${totalSpend:f2}. Remaining: ${money:f2}");
                        return;
                    default:
                        Console.WriteLine("Not Found");
                        continue;
                }
                if (money < gamePrice)
                {
                    Console.WriteLine("Too Expensive");
                }
                else
                {
                    Console.WriteLine($"Bought {game}");
                    totalSpend += gamePrice;
                    money -= gamePrice;
                }
            }
            Console.WriteLine("Out of money!");
        }
    }
}
