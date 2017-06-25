using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_2.Choose_a_Drink_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            string profession = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());
            switch (profession)
            {
                case "Athlete":
                    Console.WriteLine($"The {profession} has to pay {quantity*0.7:F2}.");
                    break;
                case "Businessman":
                case "Businesswoman":
                    Console.WriteLine($"The {profession} has to pay {quantity * 1.0:F2}.");
                    break;
                case "SoftUni Student":
                    Console.WriteLine($"The {profession} has to pay {quantity * 1.7:F2}.");
                    break;
                default:
                    Console.WriteLine($"The {profession} has to pay {quantity * 1.2:F2}.");
                    break;
            }
        }
    }
}
