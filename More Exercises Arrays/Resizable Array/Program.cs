using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resizable_Array
{
    class Program
    {
        static int CheckArray(int[] powerLevel)
        {
            int zeroEquans = 0;
            for (int i = 0; i < powerLevel.Length; i++)
            {
                zeroEquans += powerLevel[i];
            }
            return zeroEquans;
        }
        static void Main(string[] args)
        {
            int[] arr = new int[4];
            string[] entering = new string[2];
            int token = 0;
            while (entering[0] != "end")
            {
                entering = Console.ReadLine().Split(' ');
                if (entering[0] == "push")
                {
                    if (token == arr.Length)
                    {
                        int[] arr2 = new int[arr.Length * 2];
                        for (int i = 0; i < arr.Length; i++)
                        {
                            arr2[i] = arr[i];
                        }
                        arr = new int[arr2.Length];
                        for (int i = 0; i < arr.Length; i++)
                        {
                            arr[i] = arr2[i];
                        }
                    }
                    arr[token] = int.Parse(entering[1]);
                    token++;
                }
                if (entering[0] == "removeAt")
                {
                    for (int i = 0; i < arr.Length; i++)
                    {
                        if (i >= int.Parse(entering[1]))
                        {
                            if (i < arr.Length - 1)
                            {
                                arr[i] = arr[i + 1];
                            }

                        }
                    }
                    token--;
                }
                if (entering[0] == "pop")
                {
                    arr[token - 1] = 0;
                    token--;
                }
                if (entering[0] == "clear")
                {
                    token = 0;
                    arr = new int[4];
                }
                if (entering[0] == "end")
                {
                    break;
                }
            }
            if (CheckArray(arr) == 0)
            {
                Console.WriteLine("empty array");
            }
            else
            {
                for (int i = 0; i < token; i++)
                {
                    if (i == arr.Length - 1)
                    {
                       
                            Console.Write(arr[i]);
                   

                    }
                    else
                    {

                            Console.Write($"{arr[i]} ");

                    }

                }
                Console.WriteLine();

            }
        }
    }
}
