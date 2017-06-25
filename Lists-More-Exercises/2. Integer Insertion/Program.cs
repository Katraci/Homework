using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Integer_Insertion
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            string entering = "";
            while(entering!="end")
            {
                entering = Console.ReadLine();
                if (entering=="end")
                {
                    break;
                }
                else
                {
                    int posicion = GetPosition(entering);
                    numbers.Insert(posicion, int.Parse(entering));
                }
            }
            Console.WriteLine(string.Join(" ", numbers));
        }

        static int GetPosition(string entering)
        {
            int result = 0;
            int currentNumber = int.Parse(entering);
            while (currentNumber!=0)
            {
                if (currentNumber!=0)
                {
                    result = currentNumber;
                }
                currentNumber /= 10;
            }
            return result;
        }
    }
}
