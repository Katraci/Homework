using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Binary_Search
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int serchingNumber = int.Parse(Console.ReadLine());
            int linearCounter = 0;
            int binaryCounter = 0;
            bool found = false;
            for (int i = 0; i < numbers.Length; i++)
            {
                linearCounter++;
                if (numbers[i]==serchingNumber)
                {
                    found = true;
                    break;
                }
            }
            while (true)
            {
                bool sorted = true;
                for (int i = 1; i < numbers.Length; i++)
                {
                    if (numbers[i-1] > numbers[i])
                    {
                        int temp = numbers[i];
                        numbers[i] = numbers[i - 1];
                        numbers[i - 1] = temp;
                        sorted = false;
                    }
                }
                if (sorted)
                {
                    break;
                }
            }
            int uper = numbers.Length-1;
            int down = 0;
            while (uper >= down)
            {
                binaryCounter++;
                int curentPosicion = (uper + down) / 2;
                if (numbers[curentPosicion] == serchingNumber)
                {
                    found = true;
                    break;
                }
                else
                {
                    if (numbers[curentPosicion] < serchingNumber)
                    {
                        down = curentPosicion + 1;

                    }
                    if (numbers[curentPosicion] > serchingNumber)
                    {
                        uper = curentPosicion - 1;
                    }
                }

            }
            if (found)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
            Console.WriteLine($"Linear search made {linearCounter} iterations");
            Console.WriteLine($"Binary search made {binaryCounter} iterations");
        }
    }
}
