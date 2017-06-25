using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volleyball
{
    class Program
    {
        static void Main(string[] args)
        {
            var year = Console.ReadLine().ToLower();
            var holyday = double.Parse(Console.ReadLine());
            var home = double.Parse(Console.ReadLine());
            var sofiagame = (48 - home) * 3.0 / 4;
            var holydaygame = holyday * 2.0 / 3;
            switch(year)
            {
                case "normal":
                    Console.WriteLine("{0}", Math.Truncate(sofiagame + holydaygame + home));break;
                case "leap":
                    Console.WriteLine("{0}", Math.Truncate(sofiagame + holydaygame + home+(sofiagame + holydaygame + home)*0.15)); break;

            }
        }
    }
}
