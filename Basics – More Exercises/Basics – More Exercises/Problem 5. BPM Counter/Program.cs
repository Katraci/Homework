using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_5.BPM_Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            double beatsPerMinute = double.Parse(Console.ReadLine());
            double beats = double.Parse(Console.ReadLine());
            double bars = beats / 4.0;
            double seconds = 60 * beats / beatsPerMinute;
            Console.WriteLine($"{Math.Round(bars, 1)} bars - {Math.Floor(seconds/60)}m {Math.Floor(seconds % 60)}s");
        }
    }
}
