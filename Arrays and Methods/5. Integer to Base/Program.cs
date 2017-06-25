using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Integer_to_Base
{
    class Program
    {
        static void Main(string[] args)
        {
            long number = long.Parse(Console.ReadLine());
            int systemBase = int.Parse(Console.ReadLine());
            Console.WriteLine(ConvertToSystem(number, systemBase));
        }

        static string ConvertToSystem(long number, int systemBase)
        {
            string resultat = "";
            while (number>0)
            {
                resultat = (number % systemBase)+ resultat;
                number = number / systemBase;
            }

            return resultat;
        }
    }
}
