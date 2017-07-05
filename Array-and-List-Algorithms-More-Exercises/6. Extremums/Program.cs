using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Extremums
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split(' ').ToArray();
            string input = Console.ReadLine();
            int sumMax = 0;
            int sumMin = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                int maxValue = 0;
                int minValue = 100000;
                char[] number = arr[i].ToCharArray();
                int counter = 0;
                while (counter<number.Length)
                {
                    char tempor = number[number.Length - 1];
                    for (int j = number.Length-1; j >= 1 ; j--)
                    {
                        number[j] = number[j - 1];
                    }
                    number[0] = tempor;
                    int temp = int.Parse(new string(number));
                    if (temp>maxValue)
                    {
                        maxValue = temp;
                    }
                    if (temp<minValue)
                    {
                        minValue = temp;
                    }
                    counter++;
                }
                sumMax += maxValue;
                sumMin += minValue;
                if (input=="Max")
                {
                    arr[i] = maxValue.ToString();
                }
                else
                {
                    arr[i] = minValue.ToString();
                }
            }
            Console.WriteLine(string.Join(", ", arr));
            if (input == "Max")
            {
                Console.WriteLine(sumMax);
            }
            else
            {
                Console.WriteLine(sumMin);
            }
        }
    }
}
