using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altitude
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split(' ');
            bool token = true;
            bool counter = true;
            long altitude = long.Parse(arr[0]);
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i]=="down")
                {
                    token = false;
                }
                else
                {
                    if (arr[i] == "up")
                    {
                        token = true;
                    }
                    else
                    {
                        if (token)
                        {
                            altitude += long.Parse(arr[i]);
                        }
                        else
                        {
                            altitude -= long.Parse(arr[i]);
                        }
                    }
                }
                if (altitude<0|| altitude ==0)
                {
                    counter = false;
                    break;
                }
            }
            if (counter)
            {
                Console.WriteLine($"got through safely. current altitude: {altitude}m");
            }
            else
            {
                Console.WriteLine("crashed");
            }
        }
    }
}
