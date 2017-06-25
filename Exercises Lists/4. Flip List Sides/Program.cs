using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Flip_List_Sides
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers1 = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> numbers2 = new List<int>(numbers1.Count);
            for (int i = 0; i < numbers1.Count; i++)
            {
                if (i==0||i== numbers1.Count-1)
                {
                    numbers2.Add(numbers1[i]);
                }
                else
                {
                    numbers2.Add(numbers1[numbers1.Count - 1 - i]);
                }
                if (i == numbers1.Count - 1)
                {
                    Console.WriteLine(numbers2[i]);
                }
                else
                {
                    Console.Write(numbers2[i] + " ");
                }
            }
        }
    }
}
