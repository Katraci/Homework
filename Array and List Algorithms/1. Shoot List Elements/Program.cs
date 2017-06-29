using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Shoot_List_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> numbers = new List<double>();
            string input = "";
            double lastShoot = new double();
            while (input!="stop")
            {
                input = Console.ReadLine();
                if (input=="stop")
                {
                    StopTheShoot(numbers, lastShoot);
                    break;
                }
                else
                {
                    if (input== "bang")
                    {
                        if(numbers.Count==0)
                        {
                            Console.Write($"nobody left to shoot! last one was {lastShoot}");
                            break;
                        }
                        ShootNumber(numbers,ref lastShoot);
                        DecrementList(numbers);
                    }
                    else
                    {
                        numbers.Insert(0, double.Parse(input));
                    }
                }
            }
            Console.WriteLine();
        }

        private static void StopTheShoot(List<double> numbers,double lastShoot)
        {
            if (numbers.Count == 0)
            {
                Console.Write($"you shot them all. last one was {lastShoot}");
            }
            else
            {
                Console.Write("survivors: " + string.Join(" ", numbers));
            }
        }

        static void DecrementList(List<double> numbers)
        {
            for (int i = 0; i < numbers.Count; i++)
            {
                numbers[i]--;
            }
        }

        static void ShootNumber(List<double> numbers,ref double lastShoot)
        {
            double average = GetAverage(numbers);
            int posicionToShoot = 0;
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i]<average)
                {
                    posicionToShoot = i;
                    break;
                }
            }
            lastShoot = numbers[posicionToShoot];
            Console.WriteLine($"shot {lastShoot}");
            numbers.RemoveAt(posicionToShoot);
        }

        static double GetAverage(List<double> numbers)
        {          
            double sum = 0.0;
            for (int i = 0; i < numbers.Count; i++)
            {
                sum += numbers[i];
            }
            double average= sum/ numbers.Count;
            return average;
        }
    }
}
