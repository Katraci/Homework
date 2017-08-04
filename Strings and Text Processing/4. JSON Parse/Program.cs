using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.JSON_Parse
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(new string[] { "},{" }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            for (int i = 0; i < input.Length; i++)
            {
                int firstIndex = input[i].IndexOf("\"");
                int secondIndex = input[i].IndexOf("\"",firstIndex+1);
                string name = input[i].Remove(secondIndex, (input[i].Length) - secondIndex).Remove(0, firstIndex+1);
                Console.Write($"{name} : ");
                firstIndex = secondIndex + 6;
                string age = input[i].Remove(0, firstIndex);
                secondIndex = age.IndexOf("g")-1;
                firstIndex = age.IndexOf("[");
                string grades =age.Remove(0,firstIndex+1);
                age = age.Remove(secondIndex, age.Length - secondIndex);
                Console.Write($"{age} -> ");
                secondIndex = grades.IndexOf("]");
                grades = grades.Remove(secondIndex, grades.Length - secondIndex);
                if (grades=="")
                {
                    Console.WriteLine("None");
                }
                else
                {
                    Console.WriteLine(grades);
                }
               
            }
        }
    }
}
