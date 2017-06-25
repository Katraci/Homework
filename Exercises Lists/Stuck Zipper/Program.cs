using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stuck_Zipper
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers1 = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> numbers2 = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int minDigit = GetMinDigit(numbers1, numbers2);
            for (int i = 0; i < numbers1.Count; i++)
            {
                if (minDigit!=MinDigit(numbers1[i]))
                {
                    numbers1.RemoveAt(i);
                    i--;
                }
            }
            for (int i = 0; i < numbers2.Count; i++)
            {
                if (minDigit !=MinDigit(numbers2[i]))
                {
                    numbers2.RemoveAt(i);
                    i--;
                }
            }
            List<int> result = new List<int>(numbers1.Count + numbers2.Count);
            for (int i = 0; i < Math.Max(numbers1.Count, numbers2.Count); i++)
            {
                if (i<numbers2.Count)
                {
                    result.Add(numbers2[i]);
                }
                if (i < numbers1.Count)
                {
                    result.Add(numbers1[i]);
                }

            }
            for (int i = 0; i < result.Count; i++)
            {
                if (i== result.Count-1)
                {
                    Console.WriteLine(result[i]);
                }
                else
                {
                    Console.Write(result[i]+" ");
                }
            }

        }

        private static int GetMinDigit(List<int> numbers1, List<int> numbers2)
        {
            int result = MinDigit(numbers1[0]);
            for (int i = 0; i < numbers1.Count; i++)
            {
                if (result > MinDigit(numbers1[i]))
                {
                    result = MinDigit(numbers1[i]);
                }
            }
            for (int i = 0; i < numbers2.Count; i++)
            {
                if (result > MinDigit(numbers2[i]))
                {
                    result = MinDigit(numbers2[i]);
                }
            }
            return result;
        }

        static int MinDigit(int v)
        {
            if (v<0)
            {
                v = v * -1;
            }
            int result = 0;
            while (v > 0)
            {
                v = v / 10;
                result++;
            }
            return result;
        }
    }
}
