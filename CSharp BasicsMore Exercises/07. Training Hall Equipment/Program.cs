using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Training_Hall_Equipment
{
    class Program
    {
        static void Main(string[] args)
        {
            var budget = float.Parse(Console.ReadLine());
            var itemsCnt = int.Parse(Console.ReadLine());
            var itemTotalPrice = 0.00;
            for (int i = 1; i <= itemsCnt; i++)
            {
                var itemName = Console.ReadLine();
                var itemPrice = float.Parse(Console.ReadLine());
                var itemCnt = int.Parse(Console.ReadLine());
                if (itemCnt > 1)
                {
                    Console.WriteLine($"Adding {itemCnt} {itemName}s to cart.");
                }
                else
                {
                    Console.WriteLine($"Adding {itemCnt} {itemName} to cart.");
                }
                itemTotalPrice += itemPrice * itemCnt;
            }

            Console.WriteLine($"Subtotal: ${(itemTotalPrice):F2}");
            if (budget >= itemTotalPrice)
            {
                Console.WriteLine($"Money left: ${(budget - itemTotalPrice):F2}");
            }
            else
            {
                Console.WriteLine($"Not enough. We need ${(itemTotalPrice - budget):F2} more.");
            }
        }
    }
}
