using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.Largest_Element_in_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int arrLeght = int.Parse(Console.ReadLine());
            int[] arr = new int[arrLeght];
            int greaterNumber = int.MinValue;
            for (int i = 0; i < arrLeght; i++)
            {
                arr[i]=int.Parse(Console.ReadLine());
                if (arr[i] > greaterNumber)
                {
                    greaterNumber = arr[i];
                }
            }
            Console.WriteLine(greaterNumber);
        }
    }
}
