using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Filter_Base
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> age = new Dictionary<string, int>();
            Dictionary<string, double> salary = new Dictionary<string, double>();
            Dictionary<string, string> position = new Dictionary<string, string>();
            string input = "";
            while (input!= "filter base")
            {
                input = Console.ReadLine();
                if (input != "filter base")
                {
                    string[] arr = input.Split(' ').ToArray();
                    int number = 0;
                    double secondNumber = 0;
                    bool check1 = int.TryParse(arr[2], out number);
                    bool check2 = double.TryParse(arr[2], out secondNumber);
                    if (check1)
                    {
                        age[arr[0]] = number;
                    }
                    else
                    {
                        if (check2)
                        {
                            salary[arr[0]] = secondNumber;
                        }
                        else
                        {
                            position[arr[0]] = arr[2];
                        }
                    }
                }
            }
            input = Console.ReadLine();
            if (input== "Position")
            {
                foreach (KeyValuePair<string,string> item in position)
                {
                    Console.WriteLine($"Name: {item.Key}");
                    Console.WriteLine($"Position: {item.Value}");
                    Console.WriteLine("====================");
                }
            }
            else
            {
                if (input== "Salary")
                {
                    foreach (KeyValuePair<string, double> item in salary)
                    {
                        Console.WriteLine($"Name: {item.Key}");
                        Console.WriteLine($"Salary: {item.Value:F2}");
                        Console.WriteLine("====================");
                    }
                }
                else
                {
                    foreach (KeyValuePair<string, int> item in age)
                    {
                        Console.WriteLine($"Name: {item.Key}");
                        Console.WriteLine($"Age: {item.Value}");
                        Console.WriteLine("====================");
                    }
                }
            }
        }
    }
}
