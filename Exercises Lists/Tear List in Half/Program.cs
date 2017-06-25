using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tear_List_in_Half
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> splitingList = new List<int>(numbers.Count);
            int counter = 1;
            for (int i = numbers.Count/2; i < numbers.Count; i++)
            {
                splitingList.Add(numbers[i] / 10);
                splitingList.Add(numbers[i] % 10);
            }
            for (int i = splitingList.Count; i > splitingList.Count/2; i--)
            {
                numbers.RemoveAt(i-1);
            }
            for (int i = 0; i < splitingList.Count; i++)
            {
                
                if (i==counter)
                {
                    splitingList.Insert(i,numbers[i]);
                    counter += 3;
                }
                else
                {
                    numbers.Insert(i, splitingList[i]);
                }
            }
            for (int i = 0; i < numbers.Count; i++)
            {
                if (i == numbers.Count - 1)
                {
                    Console.WriteLine(numbers[i]);
                }
                else
                {
                    Console.Write(numbers[i] + " ");
                }
            }
        }
    }
}
