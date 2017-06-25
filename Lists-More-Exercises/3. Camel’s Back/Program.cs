using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Camel_s_Back
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int camelBack = int.Parse(Console.ReadLine());
            int turns = 0;
            while (camelBack!=numbers.Count)
            {
                numbers.RemoveAt(0);
                numbers.RemoveAt(numbers.Count - 1);
                turns++;
            }
            if (turns==0)
            {
                Console.WriteLine("already stable: "+string.Join(" ",numbers));
            }
            else
            {
                Console.WriteLine($"{turns} rounds");
                Console.WriteLine("remaining: " + string.Join(" ", numbers));
            }
        }
    }
}
