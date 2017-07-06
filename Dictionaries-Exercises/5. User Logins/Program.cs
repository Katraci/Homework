using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.User_Logins
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> passwords = new Dictionary<string, string>();
            string input = "";
            int counter = 0;
            while (input!= "login")
            {
                input = Console.ReadLine();
                if (input != "login")
                {
                    string[] arr = input.Split(' ').ToArray();
                    passwords[arr[0]] = arr[2];
                }
            }
            while (input!= "end")
            {
                input = Console.ReadLine();
                if (input != "end")
                {
                    string[] arr = input.Split(' ').ToArray();
                    if (passwords.ContainsKey(arr[0])&&passwords.ContainsValue(arr[2]))
                    {
                        Console.WriteLine($"{arr[0]}: logged in successfully");
                    }
                    else
                    {
                        Console.WriteLine($"{arr[0]}: login failed");
                        counter++;
                    }
                }
            }
            Console.WriteLine($"unsuccessful login attempts: {counter}");
        }
    }
}
