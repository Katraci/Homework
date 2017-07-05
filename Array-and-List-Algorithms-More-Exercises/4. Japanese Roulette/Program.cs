using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Japanese_Roulette
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] cylinder = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int curentPosicion = 0;
            for (int i = 0; i < cylinder.Length; i++)
            {
                if (cylinder[i]==1)
                {
                    curentPosicion = i;
                    break;
                }
            }
            string[] moves = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            bool dead = false;
            for (int i = 0; i < moves.Length; i++)
            {
                string[] curentMove = moves[i].Split(',').ToArray();
                int spins = int.Parse(curentMove[0]);
                if (curentMove[1]== "Right")
                {
                    curentPosicion = (curentPosicion + spins) % cylinder.Length;
                }
                else
                {
                    spins = spins % cylinder.Length;
                    if (curentPosicion-spins<0)
                    {
                        curentPosicion = cylinder.Length - Math.Abs(curentPosicion - spins);
                    }
                    else
                    {
                        curentPosicion = curentPosicion - spins;
                    }
                }
                if (curentPosicion==2)
                {
                    dead = true;
                    Console.WriteLine($"Game over! Player {i} is dead.");
                    break;
                }
                curentPosicion= (curentPosicion + 1) % cylinder.Length;
            }
            if (!dead)
            {
                Console.WriteLine("Everybody got lucky!");
            }
        }
    }
}
