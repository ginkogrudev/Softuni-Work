using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.DNA_Sequences
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var charI = ' ';
            var charK = ' ';
            var charJ = ' ';
            for (int i = 1; i <= 4; i++)
            {
                for (int k = 1; k <=4; k++)
                {

                    for (int j = 1; j <= 4; j++)
                    {
                        switch (i)
                        {
                            case 1:
                                charI = 'A';
                                break;
                            case 2:
                                charI = 'C';
                                break;
                            case 3:
                                charI = 'G';
                                break;
                            case 4:
                                charI = 'T';
                                break; 
                        }
                        switch (k)
                        {
                            case 1:
                                charK = 'A';
                                break;
                            case 2:
                                charK = 'C';
                                break;
                            case 3:
                                charK = 'G';
                                break;
                            case 4:
                                charK = 'T';
                                break;
                        }
                        switch (j)
                        {
                            case 1:
                                charJ = 'A';
                                break;
                            case 2:
                                charJ = 'C';
                                break;
                            case 3:
                                charJ = 'G';
                                break;
                            case 4:
                                charJ = 'T';
                                break;
                        }
                        if ((i + j + k) >= n)
                        {
                            Console.Write($"O{charI}{charK}{charJ}O ");

                        }
                        else
                        {
                            Console.Write($"X{charI}{charK}{charJ}X ");
                        }
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
