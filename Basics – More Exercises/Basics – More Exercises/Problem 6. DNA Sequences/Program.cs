using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_6.DNA_Sequences
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = int.Parse(Console.ReadLine());
            for (int i = 1; i <=4; i++)
            {
                for (int j = 1; j <=4; j++)
                {
                    for (int k = 1; k <=4; k++)
                    {
                        
                        if (i+j+k>=sum)
                        {
                            Console.Write("O");
                        }
                        else
                        {
                            Console.Write("X");
                        }
                        switch (i)
                        {
                            case 1: Console.Write("A");break;
                            case 2: Console.Write("C"); break;
                            case 3: Console.Write("G"); break;
                            case 4: Console.Write("T"); break;
                            default:
                                break;
                        }
                        switch (j)
                        {
                            case 1: Console.Write("A"); break;
                            case 2: Console.Write("C"); break;
                            case 3: Console.Write("G"); break;
                            case 4: Console.Write("T"); break;
                            default:
                                break;
                        }
                        switch (k)
                        {
                            case 1: Console.Write("A"); break;
                            case 2: Console.Write("C"); break;
                            case 3: Console.Write("G"); break;
                            case 4: Console.Write("T"); break;
                            default:
                                break;
                        }
                        if (i + j + k >= sum)
                        {
                            Console.Write("O ");
                        }
                        else
                        {
                            Console.Write("X ");
                        }
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
