using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Mirror_Image
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split(' ').ToArray();
            string input = "";
            while (input!= "Print")
            {
                input = Console.ReadLine();
                if (input== "Print")
                {
                    break;
                }
                else
                {
                    int curentPosition = int.Parse(input);
                    for (int i = 0; i < curentPosition/2; i++)
                    {
                      
                            string token = arr[i];
                            arr[i] = arr[curentPosition - 1 - i];
                            arr[curentPosition - 1 - i] = token;
                    }
                    for (int i = 0; i < (arr.Length-curentPosition)/2; i++)
                    {
                        string token = arr[i+1+curentPosition];
                        arr[i + 1 + curentPosition] = arr[arr.Length-1-i];
                        arr[arr.Length - 1 - i] = token;
                    }
                }
            }
            Console.WriteLine(string.Join(" ", arr));
        }
    }
}
