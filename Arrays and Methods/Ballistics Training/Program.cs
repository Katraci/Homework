using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ballistics_Training
{
    class Program
    {
        static void Main(string[] args)
        {
            long[] planeCoordinates = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
            string[] ballisticMove = Console.ReadLine().Split(' ');
            long coordinateX = 0;
            long coordinateY = 0;
            for (int i = 0; i < ballisticMove.Length; i+=2)
            {
                switch (ballisticMove[i])
                {
                    case "up":coordinateY += long.Parse(ballisticMove[i + 1]);break;
                    case "down": coordinateY -= long.Parse(ballisticMove[i + 1]); break;
                    case "left": coordinateX -= long.Parse(ballisticMove[i + 1]); break;
                    case "right": coordinateX += long.Parse(ballisticMove[i + 1]); break;
                    default:
                        break;
                }
            }
            
            if (coordinateX== planeCoordinates[0]&&coordinateY== planeCoordinates[1])
            {
                Console.WriteLine($"firing at [{planeCoordinates[0]}, {planeCoordinates[1]}]");
                Console.WriteLine("got 'em!");
            }
            else
            {
                Console.WriteLine($"firing at [{coordinateX}, {coordinateY}]");
                Console.WriteLine("better luck next time...");
            }
        }
    }
}