using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Distinct_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            for (int i = 0; i < numbers.Count; i++)
            {
                for (int j = 0; j < numbers.Count; j++)
                {
                    if (i != j && numbers[i] == numbers[j])
                    {
                        numbers.RemoveAt(j);
                        j--;

                    }
                }
            }

            Console.WriteLine(String.Join(" ", numbers));

        }
    }
}
