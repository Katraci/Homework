using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neighbour_Wars
{
    class Program
    {
        static void Main(string[] args)
        {
            int healtPesho = 100;
            int healtGosho = 100;
            int damagePesho = int.Parse(Console.ReadLine());
            int damageGosho = int.Parse(Console.ReadLine());
            int turn = 0;
            do
            {
                turn++;
                if (turn % 2 == 0)
                {
                    healtPesho -= damageGosho;
                    if (healtPesho >0)
                    {
                        Console.WriteLine($"Gosho used Thunderous fist and reduced Pesho to {healtPesho} health.");
                    }
                    else break;
                }
                else
                {
                    healtGosho -= damagePesho;
                    if (healtGosho>0)
                    {
                        Console.WriteLine($"Pesho used Roundhouse kick and reduced Gosho to {healtGosho} health.");
                    }
                    else break;
                }
                if (turn % 3 == 0)
                {
                    healtGosho += 10;
                    healtPesho += 10;
                }
            } while (healtPesho > 0 || healtGosho > 0);
            if (healtGosho<=0)
            {
                Console.WriteLine($"Pesho won in {turn}th round.");
            }
            else
            {
                Console.WriteLine($"Gosho won in {turn}th round.");
            }
        }
    }
}
