using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Character_Stats
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int currentHealt = int.Parse(Console.ReadLine());
            int maxHealt = int.Parse(Console.ReadLine());
            int currentEnergy = int.Parse(Console.ReadLine());
            int maxEnergy = int.Parse(Console.ReadLine());
            Console.WriteLine($"Name: {name}");
            Console.Write("Health: |");
            for (int i = 1; i <=maxHealt; i++)
            {
                if (i<=currentHealt)
                {
                    Console.Write("|");
                }
                else
                {
                    Console.Write(".");
                }
            }
            Console.WriteLine("|");
            Console.Write("Energy: |");
            for (int i = 1; i <= maxEnergy; i++)
            {
                if (i <= currentEnergy)
                {
                    Console.Write("|");
                }
                else
                {
                    Console.Write(".");
                }
            }
            Console.WriteLine("|");
        }
    }
}
