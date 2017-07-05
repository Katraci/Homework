using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Increasing_Crisis
{
    class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());
            int curentLine = 0;
            List<int> result = new List<int>();
            while (curentLine < lines)
            {
                List<int> numbers = Console.ReadLine()
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToList();
                if (curentLine == 0||numbers[0]>=result[result.Count-1])
                {
                    for (int i = 0; i < numbers.Count; i++)
                    {
                            result.Add(numbers[i]);
                    }
                }
                else
                {
                    int insertIndex = result.Count;
                        for (int i = 0; i <= result.Count - 1; i++)
                        {
                            if (result[i] > numbers[0])
                            {
                                insertIndex = i ;
                                break;
                            }
                        }
                    int count = 0;
                    for (int i = insertIndex; i < numbers.Count+insertIndex; i++)
                    {
                        result.Insert(i, numbers[count]);
                        count++;
                        if (result[i]>result[i+1])
                        {
                            break;
                        }
                    }
                }
                int breakIndex = 0;
                for (int i = 0; i < result.Count - 1; i++)
                {
                    if (result[i] > result[i + 1])
                    {
                        breakIndex = i + 1;
                        break;
                    }
                }
                if (breakIndex > 0)
                {
                    for (int i = breakIndex; i < result.Count; i++)
                    {
                        result.RemoveAt(i);
                        i--;
                    }
                }
                curentLine++;
            }
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
