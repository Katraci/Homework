using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Batteries
{
    class Program
    {
        static void Main(string[] args)
        {
            List<decimal> batteriesCapacities = Console.ReadLine().Split(' ').Select(decimal.Parse).ToList();
            decimal[] batteriesUsage = Console.ReadLine().Split(' ').Select(decimal.Parse).ToArray();
            decimal hours = decimal.Parse(Console.ReadLine());
            for (int i = 0; i < batteriesUsage.Length; i++)
            {
                if (batteriesCapacities[i]/batteriesUsage[i]>hours)
                {
                    Console.WriteLine($"Battery {i + 1}: {GetBatteriesLeft(batteriesCapacities[i] , batteriesUsage[i] , hours):F2} mAh ({LeftInProcent(batteriesCapacities[i], batteriesUsage[i], hours):F2})%");
                }
                else
                {
                    Console.WriteLine($"Battery {i + 1}: dead (lasted {Math.Ceiling(batteriesCapacities[i] / batteriesUsage[i])} hours)");
                }
            }
        }

        private static object LeftInProcent(decimal v1, decimal v2, decimal hours)
        {
            decimal left= v1 - (v2 * hours);
            decimal result = 100 * (left / v1);
            return result;
        }

        private static object GetBatteriesLeft(decimal v1, decimal v2, decimal hours)
        {
            decimal result = v1 - (v2 * hours);
            return result;
        }
    }
}