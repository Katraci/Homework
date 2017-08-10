using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _5.SoftUni_Messages
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string lenght = Console.ReadLine();
            while (input!= "Decrypt!")
            {
                string filter = @"(^\d+)([A-Za-z]{"+lenght+@"})(([\d\W]+)$)";
                if (Regex.IsMatch(input,filter))
                {
                    char[] token = input.ToCharArray();
                    List<char> leters = new List<char>();
                    List<int> numbers = new List<int>();
                    foreach (var item in token)
                    {
                        char helping = item;
                        if (Char.IsDigit(helping))
                        {
                            numbers.Add(int.Parse(helping.ToString()));
                        }
                        if (Char.IsLetter(helping))
                        {
                            leters.Add(helping);
                        }
                    }
                    string result = "";
                    foreach (var item in numbers)
                    {
                        if (leters.Count>item)
                        {
                            result += leters[item];
                        }
                    }
                    Console.WriteLine(string.Join("",leters)+" = "+result);
                }
                input = Console.ReadLine();
                lenght = Console.ReadLine();
                if (input== "Decrypt!")
                {
                    break;
                }
            }
            
        }
    }
}
