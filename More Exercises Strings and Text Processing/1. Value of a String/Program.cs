using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Value_of_a_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = new string(Console.ReadLine().ToCharArray().Where(c=> char.IsLetter(c)).ToArray());
            string condition = Console.ReadLine();
            switch (condition)
            {
                case "LOWERCASE":text= new string(text.ToCharArray().Where(c => char.IsLower(c)).ToArray());
                    break;
                case "UPPERCASE":
                    text = new string(text.ToCharArray().Where(c => char.IsUpper(c)).ToArray());
                    break;
                default:
                    break;
            }
            char[] leters = text.ToCharArray();
            int sum = 0;
            for (int i = 0; i < leters.Length; i++)
            {
                sum += (int)leters[i];
            }
            Console.WriteLine($"The total sum is: {sum}");
        }
    }
}
