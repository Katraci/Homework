using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Count_Occurrences_of_Larger_Numbers_in_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] arr = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            double number = double.Parse(Console.ReadLine());
            int counter = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i]>number)
                {
                    counter++;
                }
            }
            Console.WriteLine(counter);
        }
    }
}
