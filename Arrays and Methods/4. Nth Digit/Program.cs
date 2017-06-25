using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Nth_Digit
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int posicion = int.Parse(Console.ReadLine());
            int resultat = FindNthDigit(number, posicion);
            Console.WriteLine(resultat);
        }

         static int FindNthDigit(int n, int p)
        {
            for (int i = 1; i <=p-1; i++)
            {
                n = n / 10;
            }
            n = n % 10;
            return n;
        }
    }
}
