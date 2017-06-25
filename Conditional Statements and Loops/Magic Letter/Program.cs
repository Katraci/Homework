using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magic_Letter
{
    class Program
    {
        static void Main(string[] args)
        {
            char leter1 = char.Parse(Console.ReadLine());
            char leter2 = char.Parse(Console.ReadLine());
            char leter3 = char.Parse(Console.ReadLine());
            for (char i = leter1; i <=leter2; i++)
            {
                for (char j = leter1; j <=leter2; j++)
                {
                    for (char k= leter1; k <= leter2; k++)
                    {
                        if (i!=leter3&&j!=leter3&&k!=leter3)
                        {
                            Console.Write($"{i}{j}{k} ");
                        }
                    }
                }
            }
        }
    }
}
