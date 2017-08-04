using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.JSON_Stringify
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string result = "[";
            while (input!= "stringify")
            {
                string[] curentInput = input.Split(new string[] { " : ", " ->" }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                string name = curentInput[0];
                string age = curentInput[1];
                string grades = "";
                if (curentInput.Length>2)
                {
                    grades = curentInput[2].Remove(0, 1);
                }
                result = result + "{name:\"" + name + "\",age:" + age + ",grades:[" + grades + "]}";
                input = Console.ReadLine();
                if (input != "stringify")
                {
                    result += ",";
                }
            }
            result += "]";
            Console.WriteLine(result);
        }
    }
}
