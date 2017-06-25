using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_4.Hotel
{
    class Program
    {
        static void Main(string[] args)
        {
            string months = Console.ReadLine();
            decimal nights = decimal.Parse(Console.ReadLine());

            decimal priceStudio = 0.0M;
            decimal priceDouble = 0.0M;
            decimal priceSuite = 0.0M;
            switch (months)
            {
                case "May":
                case "October":
                    if (nights >7)
                    {
                        priceStudio = 50-50*0.05M;
                        priceDouble = 65M;
                        priceSuite = 75M;
                    }
                    else
                    {
                        priceStudio = 50M;
                        priceDouble = 65M;
                        priceSuite = 75M;
                    }
                    break;
                case "June":
                case "September":
                    if (nights > 14)
                    {
                        priceStudio = 60M;
                        priceDouble = 72-72*0.1M;
                        priceSuite = 82M;
                    }
                    else
                    {
                        priceStudio = 60M;
                        priceDouble = 72M;
                        priceSuite = 82M;
                    }
                    break;
                case "July":
                case "August":
                case "December":
                    if (nights > 14)
                    {
                        priceStudio = 68M;
                        priceDouble = 77M;
                        priceSuite = 89-89*0.15M;
                    }
                    else
                    {
                        priceStudio = 68M;
                        priceDouble = 77M;
                        priceSuite = 89M;
                    }
                    break;
                default:
                    break;
            }
            if ((months== "September" || months== "October")&&nights>7)
            {
                Console.WriteLine($"Studio: {priceStudio*(nights-1):F2} lv.");
                Console.WriteLine($"Double: {priceDouble*nights:F2} lv.");
                Console.WriteLine($"Suite: {priceSuite*nights:F2} lv.");
            }
            else
            {
                Console.WriteLine($"Studio: {priceStudio * nights:F2} lv.");
                Console.WriteLine($"Double: {priceDouble * nights:F2} lv.");
                Console.WriteLine($"Suite: {priceSuite * nights:F2} lv.");
            }
        }
    }
}
