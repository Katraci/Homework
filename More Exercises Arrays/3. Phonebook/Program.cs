using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Phonebook
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] phoneNumbers = Console.ReadLine().Split(' ');
            string[] names = Console.ReadLine().Split(' ');
            string currentName = "";
            while (currentName!="done")
            {
                currentName = Console.ReadLine();
                for (int i = 0; i < names.Length; i++)
                {
                    if (currentName==names[i])
                    {
                        Console.WriteLine($"{names[i]} -> {phoneNumbers[i]}");
                    }
                }
            }
        }
    }
}
