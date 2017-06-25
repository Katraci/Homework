using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Hello__Name
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            AddSalute(name);
        }
        static void AddSalute(string n)
        {
             n = "Hello, " + n + "!";
            Console.WriteLine(n);
        }
    }
}
