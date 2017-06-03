using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.BPM_Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            var BPM = double.Parse(Console.ReadLine());
            var numberOfBeats = double.Parse(Console.ReadLine());
            var sec = (numberOfBeats / BPM) * 60;
            var min = sec / 60;
            var totalSec = sec % 60;

            Console.WriteLine($"{Math.Round((numberOfBeats/4),1)} bars - {Math.Floor(min)}m {Math.Floor(totalSec)}s");

        }
    }
}