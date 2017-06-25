using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.String_Repeater
{
    class Program
    {
        private static int length;

        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());
            RepeatString(name , quantity);
        }

        static void RepeatString( string n, int m)
        {
            for (int i = 1; i <=m; i++)
            {
                Console.Write(n);
            }
            Console.WriteLine();
        }
    }
}
