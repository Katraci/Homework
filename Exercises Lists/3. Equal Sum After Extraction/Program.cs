using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Equal_Sum_After_Extraction
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers1 = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> numbers2 = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int sum1 = 0;
            int sum2 = 0;
            foreach (int item in numbers1)
            {
                sum1 += item;
                numbers2.Remove(item);
            }
            foreach (int item in numbers2)
            {
                sum2 += item;
            }
            if (sum1==sum2)
            {
                Console.WriteLine($"Yes. Sum: {sum1}");
            }
            else
            {
                Console.WriteLine($"No. Diff: {Math.Max(sum1,sum2)-Math.Min(sum1,sum2)}");
            }
        }
    }
}
