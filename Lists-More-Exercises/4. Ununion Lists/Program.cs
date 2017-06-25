using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Ununion_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int turns = int.Parse(Console.ReadLine());
            List<int> curentNumbers = new List<int>();
            for (int i = 1; i <= turns; i++)
            {
                curentNumbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
                for (int j = 0; j < curentNumbers.Count; j++)
                {
                    bool counter = true;
                    for (int k = 0; k < numbers.Count; k++)
                    {
                        if (curentNumbers[j]==numbers[k])
                        {
                            numbers.RemoveAll(a=> a==curentNumbers[j]);
                            counter = false;
                            break;
                        }
                    }
                    if (counter)
                    {
                        numbers.Add(curentNumbers[j]);
                    }
                }

            }
            
            numbers.Sort();
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
